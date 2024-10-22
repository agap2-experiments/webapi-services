namespace WebApi.Services.Example.Launcher;

public class Startup(IConfiguration configuration)
{
    public IConfiguration Configuration { get; } = configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        // Add controllers
        services.AddControllers();

        // Add Swagger generator
        services.AddSwaggerGen();

        // Add the Example service
        services.AddExampleService();
    }

    public void Configure(IApplicationBuilder app)
    {
        // Enable Swagger
        app.UseSwagger();

        // Enable Swagger UI
        app.UseSwaggerUI();

        // Enable Example service
        app.UseExampleService();
    }
}
