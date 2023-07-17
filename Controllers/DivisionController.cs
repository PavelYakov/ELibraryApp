using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteLibraryApp.Models;

namespace TesteLibraryApp.Controllers
{
    public class DivisionController : Controller
    {
        private readonly ApplicationContext _context;

        public DivisionController(ApplicationContext context)
        {
                _context=context;
        }
        public IActionResult Index()
        {
            var divisions = _context.Divisions.ToList();
            return View(divisions);
        }
    }
}
