using Microsoft.EntityFrameworkCore;
using ESII.Models; 
var builder = WebApplication.CreateBuilder(args);
// Configurar o Entity Framework Core com PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<ConviteService>();
builder.Services.AddScoped<ProjetoService>();
builder.Services.AddScoped<RelatorioProjService>();
builder.Services.AddScoped<RelatorioService>();
builder.Services.AddScoped<TarefaService>();
builder.Services.AddScoped<UtilizadorProjetoService>();
builder.Services.AddScoped<UtilizadorService>();



builder.Services.AddControllersWithViews(); // Importante para carregar as Views

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles(); // Permite carregar arquivos estáticos como CSS, JS, imagens
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Garante que inicia na página correta

app.Run();