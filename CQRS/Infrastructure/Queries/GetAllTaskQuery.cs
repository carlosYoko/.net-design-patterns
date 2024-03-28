using CQRSSimple.Application.DTOs;
using MediatR;

namespace CQRSSimple.Infrastructure.Queries;

public record GetAllTaskQuery : IRequest<IEnumerable<TaskItemDto>>;