using BizLand.DAL;
using BizLand.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizLand.Controllers
{
    public class HomeController : Controller
    {
        private readonly BizLandDbContext _context;

        public HomeController(BizLandDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel HomeViewModel = new HomeViewModel() {

                Feature = _context.Features.ToList(),
                Service = _context.Services.ToList(),
                Testimonial = _context.Testimonials.ToList(),
                Team = _context.Team.ToList(),
                Portfolio = _context.Portfolio.ToList(),
                Pricing = _context.Pricing.ToList()

                
            };

            return View(HomeViewModel);
        }
    }
}
