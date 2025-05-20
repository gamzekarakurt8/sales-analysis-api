using SalesAnalysis.data;
using Microsoft.EntityFrameworkCore;
using SalesAnalysis.models;


var builder = WebApplication.CreateBuilder(args);


// DB baðlantýsý (MySQL için)
builder.Services.AddDbContext<AppDbContext>(options =>
	options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
	new MySqlServerVersion(new Version(8, 0, 0)))); // Buradaki versiyonu kendi MySQL versiyonuna göre yaz

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using (var scope = app.Services.CreateScope())
{
	var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

	if (!context.Sales.Any())
	{
		var sales = new List<Sale>
		{
			new Sale { SaleDate = new DateTime(2025, 01, 12), Amount = 500 },
			new Sale { SaleDate = new DateTime(2025, 01, 20), Amount = 1200 },
			new Sale { SaleDate = new DateTime(2025, 02, 05), Amount = 3500 },
			new Sale { SaleDate = new DateTime(2025, 03, 15), Amount = 4200 }
		};

		context.Sales.AddRange(sales);
		context.SaveChanges();
	}
}
