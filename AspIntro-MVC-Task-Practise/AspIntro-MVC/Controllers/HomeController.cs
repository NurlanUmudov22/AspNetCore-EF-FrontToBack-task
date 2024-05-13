using AspIntro_MVC.Data;
using AspIntro_MVC.Models;
using AspIntro_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspIntro_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly    AppDbContext _context;

        public  HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
          
            List<Slider> sliders = await _context.Sliders.ToListAsync();
        
            return View(sliders);
        }

       



      


     


    }
}

















