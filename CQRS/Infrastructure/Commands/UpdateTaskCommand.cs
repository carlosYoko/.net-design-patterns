using CQRSSimple.Application.DTOs;
using MediatR;

namespace CQRSSimple.Infrastructure.Commands;

public record UpdateTaskCommand (int Id, string Title, string Description, bool IsCompleted): IRequest<TaskItemDto>;
