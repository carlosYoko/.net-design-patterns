using CQRSSimple.Application.DTOs;
using MediatR;

namespace CQRSSimple.Infrastructure.Queries;

public record GetTaskByIdQuery(int Id) : IRequest<TaskItemDto>;