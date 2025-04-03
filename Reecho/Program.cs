using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Reecho.Data;
using Reecho.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(corsOptions => corsOptions.AddPolicy("AllowLocalhost", corsPolicyBuilder => corsPolicyBuilder
    .WithOrigins("http://localhost:5173")
    .AllowAnyHeader()
    .AllowAnyMethod()));

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtOptions =>
    {   
        JwtOptions.TokenValidationParameters = new()
        {
            ValidateIssuer = true,
            
        };
    }); 
builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<PostgreeDbContext>();
builder.Services.AddScoped<IVynilRepository, VynilRepository>();
builder.Services.AddScoped<ISerializerService, SerializerService>();
builder.Services.AddAsyncInitializer<DbInit>();

var app = builder.Build();

app.UseCors();

app.UseSwagger();
app.UseSwaggerUI();

app.UseStaticFiles();

app.MapVinylEndpoints();

await app.InitAndRunAsync();