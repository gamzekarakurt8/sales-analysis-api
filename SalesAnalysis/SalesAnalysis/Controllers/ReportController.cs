using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using SalesAnalysis.data;
using SalesAnalysis.models;

namespace SalesAnalysis.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReportController : Controller
	{
		private readonly AppDbContext _context;

		public ReportController(AppDbContext context)
		{
			_context = context;
		}

		[HttpGet("monthlysales")]
		public async Task<IActionResult> GetMonthlySales()
		{
			var sales = await _context.Sales.ToListAsync();
			return Ok(sales);
		}

		[HttpPost("AddSale")]
		public async Task<IActionResult> AddSale([FromBody] Sale sale)
		{
			if (sale == null)
				return BadRequest("Satış verisi eksik.");

			_context.Sales.Add(sale);
			await _context.SaveChangesAsync();

			return Ok("Satış başarıyla eklendi.");
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
	}
}
