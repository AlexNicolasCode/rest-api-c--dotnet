using Microsoft.EntityFrameworkCore;
using RestAPI.Database;
using RestAPI.Services;
using RestAPI.UseCases;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
string? dbUrl = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddControllers();
builder.Services.AddScoped<LoadProductsUseCase, LoadProductsService>();
builder.Services.AddScoped<LoadProductByIdUseCase, LoadProductbyIdService>();
builder.Services.AddScoped<CreateProductUseCase, CreateProductService>();
builder.Services.AddScoped<UpdateProductByIdUseCase, UpdateProductbyIdService>();
builder.Services.AddScoped<DeleteProductByIdUseCase, DeleteProductByIdService>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(dbUrl));
WebApplication app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();