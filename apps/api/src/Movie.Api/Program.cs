WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{
    _ = app.UseSwagger().UseSwaggerUI();
}

await app.RunAsync();
