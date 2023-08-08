var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add YARP
builder.Services.AddReverseProxy()
                .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

// Add YARP
app.MapReverseProxy();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();