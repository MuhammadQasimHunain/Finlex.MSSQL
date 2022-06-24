using Finlex.MSSQL.Data.Repository;
using Finlex.MSSQL.Data.Seeders;
using Finlex.MSSQL.Services;
using FinlexApp.DataLibrary;
using FinlexApp.DataLibrary.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://127.0.0.1.com");
                      });
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbOrderContext>(
    options =>
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
    });

builder.Services.AddTransient<OrderSeeder>();
//Add Repository Pattern
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();


//Add Services
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddMvc(option => option.EnableEndpointRouting = false)
    .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (args.Length == 1 && args[0].ToLower() == "seeddata")
    SeedData(app);

//Seed Data
void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory?.CreateScope())
    {
        var service = scope?.ServiceProvider.GetService<OrderSeeder>();
        service?.Seed();
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);

app.MapControllers();

app.Run();
