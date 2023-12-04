using System;
using BackEnd.Model;
using BackEnd.Services;
using Trevisharp.Security.Jwt;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<VascoContext>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IProdutoService, ProdutoService>();
builder.Services.AddSingleton<ISecurityService, SecurityService>();
builder.Services.AddSingleton<CryptoService>( p => new() {
    InternalKeySize = 24,
    UpdatePeriod = TimeSpan.FromDays(1)
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("DefaultPolicy",
        policy => {
            policy
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin();
        });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
