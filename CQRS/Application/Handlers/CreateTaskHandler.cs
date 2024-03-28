using CQRSSimple.Application.DTOs;
using CQRSSimple.Domain;
using CQRSSimple.Infrastructure;
using CQRSSimple.Infrastructure.Commands;
using MediatR;

namespace CQRSSimple.Application.Handlers;

public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, TaskItemDto>
{
    private readonly ApplicationDbContext _dbContext;

    public CreateTaskHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<TaskItemDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
    {
        var taskItem = new TaskItem()
        {
            Title = request.Title,
            Description = request.Description
        };
        
        _dbContext.TaskItems.Add(taskItem);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return new TaskItemDto()
        {
            Id = taskItem.Id,
            Title = taskItem.Title,
            Description = taskItem.Description,
            IsCompleted = taskItem.IsCompleted
        };
    }
}