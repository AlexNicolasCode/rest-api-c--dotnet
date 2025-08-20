using Microsoft.EntityFrameworkCore;
using API.Database;
using API.Services;
using API.UseCases;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
string? dbUrl = Environment.GetEnvironmentVariable("DB_URL");
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