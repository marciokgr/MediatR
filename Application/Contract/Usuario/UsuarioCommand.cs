namespace MediatR.Application.Contract.Usuario;

public class UsuarioCadastroCommand : IRequest<string>
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Nome { get; set; }

    public string Endereco { get; set; }

    public string Sexo { get; set; }
}


public class UsuarioCadastroResult
{
    public bool Sucesso { get; set; }
}
