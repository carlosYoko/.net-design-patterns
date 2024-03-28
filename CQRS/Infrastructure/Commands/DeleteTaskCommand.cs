using MediatR;

namespace CQRSSimple.Infrastructure.Commands;

public record DeleteTaskCommand (int Id): IRequest<bool>;