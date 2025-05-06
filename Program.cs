using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a controladores com views (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Pipeline de requisição HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Detalha erros durante o desenvolvimento
}
else
{
    app.UseExceptionHandler("/Home/Error"); // Página genérica de erro para produção
    app.UseHsts(); // Força uso de HTTPS
}

app.UseHttpsRedirection(); // Redireciona HTTP para HTTPS
app.UseStaticFiles();      // Permite servir arquivos estáticos como CSS/JS

app.UseRouting(); // Ativa o sistema de roteamento

// Define rota padrão apontando para o controlador "Tarefa" e ação "Index"
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Tarefa}/{action=Index}/{id?}");

app.Run();
