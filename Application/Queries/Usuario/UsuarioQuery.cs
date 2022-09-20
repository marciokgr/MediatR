namespace MediatR.Application.Queries.UsuarioQuery;

public class UsuarioByIdQuery : IRequest<UsuarioByIdQueryResult>
{
    public Guid Id { get; set; }

    public string Nome { get; set; }

    public string Endereco { get; set; }

    public string Sexo { get; set; }
}

public class UsuarioByIdQueryResult
{
    public Guid Id { get; set; }

    public string Nome { get; set; }

    public string Endereco { get; set; }

    public string Sexo { get; set; }
}