using AspIntro_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace AspIntro_MVC.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
