using CQRSSimple.Application.DTOs;
using CQRSSimple.Infrastructure;
using CQRSSimple.Infrastructure.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSSimple.Application.Handlers;

public class GetAllTaskHandler : IRequestHandler<GetAllTaskQuery, IEnumerable<TaskItemDto>>
{
    private ApplicationDbContext _dbContext;

    public GetAllTaskHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<IEnumerable<TaskItemDto>> Handle(GetAllTaskQuery request, CancellationToken cancellationToken)
    {
        var tasks = await _dbContext.TaskItems.ToListAsync(cancellationToken);

        return tasks.Select(t => new TaskItemDto()
        {
            Id = t.Id,
            Title = t.Title,
            Description = t.Description,
            IsCompleted = t.IsCompleted
        });

    }
}