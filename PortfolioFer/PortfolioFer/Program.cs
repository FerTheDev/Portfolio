using PortfolioFer.Features.Profile.Repositories;
using PortfolioFer.Features.Profile.Services;
using PortfolioFer.Features.Projects.Repositories;
using PortfolioFer.Features.Projects.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Dependency Injection
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IProfileService, ProfileService>();
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();

// 🔥 CORS 
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 🔥 ORDEM CORRETA (ESSENCIAL)
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();