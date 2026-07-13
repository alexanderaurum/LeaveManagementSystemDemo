using LeaveManagementSystemDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystemDemo.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            TestViewModel model = new();

            return View(model);
        }
    }
}
