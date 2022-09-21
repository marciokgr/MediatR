using MediatR;
using Microsoft.AspNetCore.Mvc;
using MediatR.Application.Contract.Usuario;

namespace MediatR.WebApi.Controllers;

[Route("api/[controller]")]
public class CommandsController : Controller
{
    private readonly IMediator _mediator;

    public CommandsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("usuario")]
    public async Task<IActionResult> PostUsuarioAsync([FromBody] UsuarioCadastroCommand usuario)
    {
        var command = await _mediator.Send(usuario);
        return Json(command);
    }
}