var builder = WebApplication.CreateBuilder(args);

// Adicionando os serviços necessários (MVC)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuração do pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();  // Responsável por servir arquivos estáticos (CSS, JS, imagens, etc.)

app.UseRouting();

// Configuração das rotas, ajustando para o TaskController
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Task}/{action=Index}/{id?}");

app.Run();
