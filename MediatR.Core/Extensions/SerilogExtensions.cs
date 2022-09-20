using Microsoft.Extensions.Configuration;
using Serilog;

namespace MediatR.Core.Extensions
{
    public class LogExtensions
    {
        public static void AddSerilogApi(IConfiguration configuration)
        {
            /*Log.Logger = new LoggerConfiguration()            
            .Enrich.WithProperty("ApplicationName", "API MediatR")
            .Enrich.FromLogContext()
            .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}")
            .CreateLogger();
            */
        }
    }
}