using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using TesteLibraryApp.Models;


namespace TesteLibraryApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext _context;

        public EmployeeController(ApplicationContext context)
        {
                _context=context;
        }
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            var employee = _context.Employees
                                             .Include(e => e.Division)
                                             .FirstOrDefault(e => e.ID == id);


            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
        //Редактирование 
        public IActionResult EditPost(int id)
        {
            
            if (id!= null)
            {
                Employee employee = _context.Employees
                    .Include(e => e.Division)
                    .FirstOrDefault(e => e.ID == id);
                    
                return View(employee);
                
            }
            return NotFound();

        }

        [HttpPost] // изменяет фамилию сотрудника
        public IActionResult EditPost(Employee employee)
        {
            //if (!ModelState.IsValid)
            //{
            //    var errors = ModelState.Values.SelectMany(v => v.Errors)
            //        .Select(e => e.ErrorMessage);

            //    // Вывести ошибки валидации для отладки
            //    foreach (var error in errors)
            //    {
            //        Console.WriteLine(error);
            //    }
            //}
            if (ModelState.IsValid)
            {
                
                _context.Employees.Update(employee);
                _context.SaveChanges();

            }
            //_context.Employees.Update(employee);
            //_context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        

    }
}
