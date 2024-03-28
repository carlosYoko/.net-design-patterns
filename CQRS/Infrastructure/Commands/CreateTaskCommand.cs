using CQRSSimple.Application.DTOs;
using MediatR;

namespace CQRSSimple.Infrastructure.Commands;

public record CreateTaskCommand(string Title, string Description) : IRequest<TaskItemDto>;
