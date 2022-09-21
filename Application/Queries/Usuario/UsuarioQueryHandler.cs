using MediatR.Application.Contract.Usuario;
using Serilog;

namespace MediatR.Application.Queries.UsuarioQuery;

public class UsuarioQueryHandler : 
    IRequestHandler<UsuarioByIdQueryRequest, UsuarioByIdQueryResult>
{
    public async Task<UsuarioByIdQueryResult> Handle(UsuarioByIdQueryRequest request, CancellationToken cancellationToken)
    {
        Log.Information("Query executada");

        return await Task.FromResult(new UsuarioByIdQueryResult { Id = request.Id, Nome = request.Nome });
    }
}