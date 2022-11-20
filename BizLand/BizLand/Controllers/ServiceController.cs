using BizLand.DAL;
using BizLand.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BizLand.Controllers
{
    public class ServiceController : Controller
    {
        private readonly BizLandDbContext _context;

        public ServiceController(BizLandDbContext context)
        {
            _context = context;
        }
        public IActionResult Detail(int id)
        {
            Services Service = _context.Services.ToList().Find(x => x.Id == id);

            return View(Service);
        }
    }
}
