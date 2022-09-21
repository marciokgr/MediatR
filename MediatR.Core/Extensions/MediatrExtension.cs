using Microsoft.Extensions.DependencyInjection;
using MediatR.Application.Queries.UsuarioQuery;
using MediatR.Application.Commands.UsuarioCommand;

namespace MediatR.Core.Extensions
{
    public static class MediatrExtension
    {
        public static void AddMediatRApi(this IServiceCollection services)
        {
           services.AddMediatR(typeof(UsuarioQueryHandler));
           services.AddMediatR(typeof(UsuarioCommandHandler));
        }
    }
}