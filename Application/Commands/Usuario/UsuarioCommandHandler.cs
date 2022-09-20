using Serilog;

namespace MediatR.Application.Commands.UsuarioCommand;

public class UsuarioCommandHandler : IRequestHandler<UsuarioCommand, string>
{
    private readonly IMediator _mediator;

    public UsuarioCommandHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<string> Handle(UsuarioCommand request, CancellationToken cancellationToken)
    {

        Log.Information("Usuário command");

        //await _mediator.Publish(new ProductSavedNotification { Id = request.Id }, cancellationToken);
        //await _mediator.Publish(new SendEmailNotification { Email = "test@mail.com" }, cancellationToken);

        return await Task.FromResult("Ok");
    }
}