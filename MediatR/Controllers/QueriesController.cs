using MediatR;
using Microsoft.AspNetCore.Mvc;
using MediatR.Application.Contract.Usuario;

namespace Sample.MediatR.WebApi.Controllers;

[Route("api/[controller]")]
public class QueriesController : Controller
{
    private readonly IMediator _mediator;

    public QueriesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("usuario")]
    public async Task<IActionResult> GetProductByIdAsync([FromQuery] UsuarioByIdQueryRequest product)
    {
        var queryProduct = await _mediator.Send(product);

        return Json(queryProduct);
    }
}
