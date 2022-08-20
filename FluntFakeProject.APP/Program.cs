using FluntFakeProject.Domain.Handlers;
using Flunt.Notifications;
using Flunt.Validations;

namespace FluntFakeProject.APP;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddAuthorization();
        var app = builder.Build();
        app.UseHttpsRedirection();
        app.UseAuthorization();

        app.MapPost("/v1/person", async (Handler handler, RequestName requestName) =>
        {
            Response response = await handler.HandleAsync(requestName);
            return response.IsValid 
            ? Results.Ok(response)
            : Results.BadRequest(response);
        });

        app.Run();
    }
}