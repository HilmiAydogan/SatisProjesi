
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class DashboardController :Controller
    {
        public IActionResult Index()
        {
            TempData["info"] = $"Welcomeback {DateTime.Now.ToShortDateString()}";
            return View();
        }
    }
}