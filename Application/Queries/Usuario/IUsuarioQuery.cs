using MediatR.Application.Contract.Usuario;


namespace MediatR.Application.Queries.UsuarioQuery
{
    public interface IUsuarioQuery
    {
        Task<UsuarioByIdQueryResult> GetCadastro(UsuarioByIdQueryRequest queryRequest);
    }
}
