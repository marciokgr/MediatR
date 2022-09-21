using MediatR.Application.Contract.Usuario;

namespace MediatR.Application.Commands.Usuario
{
    public interface IUsuarioCommand
    {
        Task<UsuarioCadastroResult> PostCadastro(UsuarioCadastroCommand queryRequest);
    }
}
