using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace GymEquiptmentManagement.Web.Controllers
{
    public class EquiptmentController : Controller
    {
        private EquiptmentService _equipmentService = new EquiptmentService();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewEquipment()
        {
            return View();
        }
        public IActionResult UpdateEquipment()
        {
            return View();
        }

        public IActionResult GetAllEquipment()
        {
            var result = _equipmentService.GetAll();
            return Json(result);
        }

        

        [HttpGet]
        public IActionResult GetEquipmentById(int equipmentId)
        {
            EquiptmentService _EquiptmentService = new EquiptmentService();
            var equipment = _EquiptmentService.GetById(equipmentId);
            var result = new { equipment };
            return Json(result);
        }

        public void EquipmentTester()
        {
            EquiptmentService EquiptmentService = new EquiptmentService();
            tblEquiptment equiptment = new tblEquiptment();
            equiptment.EquiptmentName = "TestEQ";
            equiptment.EquiptmentDescription = "TestEQ";
            equiptment.MaxReserveTimeMinute = 30;
            equiptment.DateAdded = DateTime.Now;

            EquiptmentService.Add(equiptment);


        }

        [HttpPost]
        public void InsertEquipment(tblEquiptment equipmentData)
        {
            EquiptmentService _EquipmentService = new EquiptmentService();
            tblEquiptment equipment = new tblEquiptment();
            equipment.EquiptmentName = equipmentData.EquiptmentName;
            equipment.EquiptmentDescription = equipmentData.EquiptmentDescription;
            equipment.MaxReserveTimeMinute = equipmentData.MaxReserveTimeMinute;
            equipment.DateAdded = DateTime.Now;

            _EquipmentService.Add(equipment);
      
        }

        [HttpPost]
        public IActionResult UpdateEquipmentData(tblEquiptment equiptmentData)
        {
            EquiptmentService _EquiptmentService = new EquiptmentService();
            var upEquipment= _EquiptmentService.Update(equiptmentData);
            var result = new { upEquipment };
            return Json(result);
        }

        [HttpPost]
        public IActionResult DeleteEquipment(int equipmentId)
        {
            EquiptmentService EquiptmentService = new EquiptmentService();
            var delEquipment = EquiptmentService.Delete(equipmentId);
            var result = new { delEquipment };
            return Json(result);
        }
    }
}
