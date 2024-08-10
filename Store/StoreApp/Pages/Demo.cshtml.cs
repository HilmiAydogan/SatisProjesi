using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Pages
{
    public class DemoModel : PageModel
    {
        public String? FullName => HttpContext?.Session?.GetString("name") ?? "";

        public DemoModel()
        {
            
        }

        public void OnGet()
        {

        }

        public void OnPost([FromForm] string name)
        {
            HttpContext.Session.SetString("name",name);
        }
    }
}