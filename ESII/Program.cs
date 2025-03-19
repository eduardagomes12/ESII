using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ESII.Models;

var builder = WebApplication.CreateBuilder(args);

// 🔹 1️⃣ Configurar o Entity Framework Core com PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🔹 2️⃣ Configurar Identity para autenticação de usuários (com suporte a roles)
builder.Services.AddIdentity<Utilizador, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false; // Permite login sem e-mail confirmado
})
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders(); // 🔥 Necessário para reset de senha e email

// 🔹 3️⃣ Redirecionar usuários não autenticados para a página de login
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Conta/Login";  // Caminho para login
    options.AccessDeniedPath = "/Conta/AcessoNegado"; // Caminho para acesso negado
});

// 🔹 4️⃣ Adicionar Serviços (Depende de cada funcionalidade)
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<ConviteService>();
builder.Services.AddScoped<ProjetoService>();
builder.Services.AddScoped<RelatorioProjService>();
builder.Services.AddScoped<RelatorioService>();
builder.Services.AddScoped<TarefaService>();
builder.Services.AddScoped<UtilizadorProjetoService>();
builder.Services.AddScoped<UtilizadorService>();

// 🔹 5️⃣ Adicionar MVC para carregar Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 🔹 6️⃣ Configurar Middleware para execução do app
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// 🔹 7️⃣ Habilitar autenticação e autorização no sistema
app.UseAuthentication(); // Login obrigatório antes de acessar páginas privadas
app.UseAuthorization();

// 🔹 8️⃣ Configurar Rotas (Home -> Padrão Inicial)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
