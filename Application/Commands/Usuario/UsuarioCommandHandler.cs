using Serilog;
using MediatR.Application.Contract.Usuario;
using MediatR;
using MediatR.Application.Commands.Usuario;

namespace MediatR.Application.Commands.UsuarioCommand;

public class UsuarioCommandHandler : IRequestHandler<UsuarioCadastroCommand, string>
{
    private readonly IMediator _mediator;
    private readonly IUsuarioCommand _usuario;

    public UsuarioCommandHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<string> Handle(UsuarioCadastroCommand request, CancellationToken cancellationToken)
    {
        //insert product in database
        Log.Information($"Command: {request.Id}");

        /*var result = new UsuarioCadastroResult();
        result = await _usuario.PostCadastro(request);
        result.Sucesso = true;
        */

        /*await _mediator.Publish(new ProductSavedNotification { Id = request.Id }, cancellationToken);
        await _mediator.Publish(new SendEmailNotification { Email = "test@mail.com" }, cancellationToken);
        */
        return await Task.FromResult("Ok");
    }
}
