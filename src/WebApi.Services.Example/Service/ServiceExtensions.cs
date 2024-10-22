using WebApi.Services.Example.EndPoints.GetRandomNumber;

namespace WebApi.Services.Example;

public static class ServiceExtensions
{
    public static IServiceCollection AddExampleService(this IServiceCollection self) => self
        .AddSingleton<IGetRandomNumberService, GetRandomNumberService>();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="self"></param>
    /// <returns></returns>
    public static IApplicationBuilder UseExampleService(this IApplicationBuilder self) => self
        .UseRouting()
        .UseEndpoints(builder =>
        {
            // Add the GetRandomNumber endpoint
            builder.MapGet($"Example/{nameof(EndPoints.GetRandomNumber)}", (IGetRandomNumberService service) => service.GetRandomNumber())
                   .WithTags("Example")
                   .WithName(nameof(EndPoints.GetRandomNumber))
                   .WithDescription("Gets a random number.");
        });
}
