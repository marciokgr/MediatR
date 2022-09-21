using MediatR.Core.Middlewares;
using MediatR.Core.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
LogExtensions.AddSerilogApi(builder.Configuration);
builder.Host.UseSerilog(Log.Logger);
var services = builder.Services;

services.AddRouting(options => options.LowercaseUrls = true); //tudo em minusculo
services.AddControllers();
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddMediatRApi();

var app = builder.Build();

//Middlewares
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<RequestSerilLogMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
