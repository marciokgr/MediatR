
using Microsoft.Extensions.DependencyInjection;
using MediatR.Application.Queries.UsuarioQuery;

namespace MediatR.Core.Extensions
{
    public static class MediatrExtension
    {
        public static void AddMediatRApi(this IServiceCollection services)
        {
           services.AddMediatR(typeof(UsuarioByIdQuery));
        }
    }
}