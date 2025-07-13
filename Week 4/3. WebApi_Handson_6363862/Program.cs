using WebApplication1_6363862.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<CustomAuthFilter>();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Swagger Demo",
        Version = "v1",
        Description = "Demo API using Swagger"
    });
});

builder.Services.AddControllers(options =>
{
    options.Filters.Add<CustomExceptionFilter>();
});

var app = builder.Build();

// Enable Swagger for all environments (optional: restrict to dev)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Demo");
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
