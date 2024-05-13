using AspIntro_MVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace AspIntro_MVC.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;

        public WorkController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
