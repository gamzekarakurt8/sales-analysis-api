using Microsoft.EntityFrameworkCore;
using SalesAnalysis.models;


namespace SalesAnalysis.data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Sale> Sales { get; set; }

	}
}
