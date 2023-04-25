using Eterna.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Eterna2WithDb.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly EternaDbContext _context;

        public PortfolioController(EternaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //var data = _context.Portfolios.Include(x => x.PortfolioImages.Id).ToList() ;
            var data = _context.Portfolios.Include(x=>x.PortfolioImages).ToList();
            return View(data);
        }
    }
}
