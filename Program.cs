using Microsoft.Extensions.Options;
using proyecto_DBP.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .Add(new ServiceDescriptor(typeof(IProducto),
        new ProductoRepository()));
builder.Services
    .Add(new ServiceDescriptor(typeof(IUsuario),
        new UsuarioRepository()));
builder.Services
    .Add(new ServiceDescriptor(typeof(IHorario),
        new HorarioRepository()));
builder.Services
    .Add(new ServiceDescriptor(typeof(IReserva),
        new ReservaRepository()));
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(3600);
});

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

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
