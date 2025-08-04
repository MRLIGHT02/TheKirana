
using Microsoft.EntityFrameworkCore;
using ServiceContract;
using Services;
using TheKirana.Data.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );


// Registering Services

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IRegister, RegisterUser>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();



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
