#region Manuten��es/Implementa��es
/*
 * 31/05/2024 - Implementa��o inicial
 */
#endregion
using LanchesStore.Context;
using LanchesStore.Repositories;
using LanchesStore.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddControllersWithViews();

//Fornece as depend�ncias da classe LancheRepository e CategoriaRepository

/*AddTransient -> O AddTransient � usado quando voc� quer que um novo objeto do servi�o seja criado toda vez que ele for injetado ou requisitado. Isso � �til para servi�os que n�o mant�m estado e s�o leves o suficiente para serem criados v�rias vezes.*/
builder.Services.AddTransient<ILancheRepository, LancheRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();

/*AddSingleton -> O novo objeto do servi�o permanece em todo tempo de vida da aplica��o, e s� � necess�rio declarar 1 vez*/
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

//Adiciona os Middlewares rerspons�veis para utiliza��o de Sessions no navegador
builder.Services.AddMemoryCache();
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
