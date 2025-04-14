var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run();

app.UseDefaultFiles(); // Serve index.html por padrão
app.UseStaticFiles(); // Permite servir os arquivos da pasta wwwroot 

app.MapGet("/index", async context => 
{
    await context.Response.SendFileAsync("wwwroot/index.html");
});