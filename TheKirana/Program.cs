
using Microsoft.EntityFrameworkCore;
using ServiceContract;
using Services;
using TheKirana.Data.Data;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );


// Registering Services

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IOrderService, OrderService>();
builder.Services.AddTransient<IAddressService, AddressService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<ICartService, CartService>();



// Adding Controllers
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IAppDbInitializer, DbInitializer>();




var app = builder.Build();
app.UseStaticFiles(
    new StaticFileOptions
    {
        FileProvider = new Microsoft.Extensions.FileProviders.PhysicalFileProvider(
        System.IO.Path.Combine(builder.Environment.ContentRootPath, "wwwroot", "Product")

    ),
        RequestPath = "/Product"
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
