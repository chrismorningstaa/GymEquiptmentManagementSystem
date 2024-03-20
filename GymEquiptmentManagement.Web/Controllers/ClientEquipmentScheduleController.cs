using Microsoft.AspNetCore.Mvc;

namespace GymEquiptmentManagement.Web.Controllers
{
    public class ClientEquipmentScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
