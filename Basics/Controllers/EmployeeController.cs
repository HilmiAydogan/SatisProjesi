using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string massage = $"Hello World. {DateTime.Now.ToString()}";
            return View("Index1",massage);

        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Hilmi",
                "Tahsin",
                "Ahmet"
            };
            return View(names);

        }

        public IActionResult Index3()
        { 
            var list = new List<Employee>()
            {
                new Employee(){Id=1, FirstName="Hilmi", LastName="Aydogan", Age=22},
                new Employee(){Id=2, FirstName="Tahsin", LastName="Gokceer", Age=21},
                new Employee(){Id=3, FirstName="Ahmet", LastName="Tatyuz", Age=20}
            };
            return View(list);
        }
    }
}