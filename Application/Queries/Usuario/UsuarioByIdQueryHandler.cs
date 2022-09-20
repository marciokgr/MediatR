using Serilog;

namespace MediatR.Application.Queries.UsuarioQuery;

public class UsuarioByIdQueryHandler : IRequestHandler<UsuarioByIdQuery, UsuarioByIdQueryResult>
{
    public async Task<UsuarioByIdQueryResult> Handle(UsuarioByIdQuery request, CancellationToken cancellationToken)
    {
        Log.Information("Query executada");

        return await Task.FromResult(new UsuarioByIdQueryResult { Id = request.Id, Nome = request.Nome });
    }
}