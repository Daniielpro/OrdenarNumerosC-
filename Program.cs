using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configurar el middleware de la aplicación.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

// Agregar el endpoint para la lógica de ordenación
app.MapPost("/ordenar", (string numeros) =>
{
    var numerosArray = numeros.Split(',')
        .Select(n => int.TryParse(n, out int num) ? num : 0)
        .OrderBy(n => n)
        .ToArray();
    return string.Join(", ", numerosArray);
});

// Configurar el puerto en el que la aplicación escuchará
app.Urls.Add("http://*:8083"); // Asegúrate de que esté configurado para escuchar en el puerto 8083

app.Run();