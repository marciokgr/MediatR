namespace MediatR.Application.Commands.UsuarioCommand;

public class UsuarioCommand : IRequest<string>
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Nome { get; set; }

    public string Endereco { get; set; }

    public string Sexo { get; set; }
}