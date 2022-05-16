using Microsoft.AspNetCore.Mvc;

namespace Lab6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Error()
        {
            return this.View();
        }
    }
}
