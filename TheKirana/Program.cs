using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TheKirana.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );


// Adding Controllers
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IAppDbInitializer, DbInitializer>();




var app = builder.Build();
app.UseStaticFiles(
    new StaticFileOptions
    {
        FileProvider = new Microsoft.Extensions.FileProviders.PhysicalFileProvider(
        System.IO.Path.Combine(builder.Environment.ContentRootPath, "wwwroot", "Product")
    )
    }
    );

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization();


app.MapControllers();

app.Run();
