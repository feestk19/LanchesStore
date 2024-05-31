#region Manutenções/Implementações
/*
 * 31/05/2024 - Implementação inicial
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

//Fornece as dependências da classe LancheRepository e CategoriaRepository

/*AddTransient -> O AddTransient é usado quando você quer que um novo objeto do serviço seja criado toda vez que ele for injetado ou requisitado. Isso é útil para serviços que não mantêm estado e são leves o suficiente para serem criados várias vezes.*/
builder.Services.AddTransient<ILancheRepository, LancheRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();

/*AddSingleton -> O novo objeto do serviço permanece em todo tempo de vida da aplicação, e só é necessário declarar 1 vez*/
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

//Adiciona os Middlewares rersponsáveis para utilização de Sessions no navegador
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
