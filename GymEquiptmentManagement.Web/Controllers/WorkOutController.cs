using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace GymEquiptmentManagement.Web.Controllers
{
    public class WorkOutController : Controller
    {
        private WorkOutService _workOutService = new WorkOutService();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNewWorkOut()
        {
            EquiptmentService _EquipmentService = new EquiptmentService();
            ViewBag.Equipments = _EquipmentService.GetAll();
            return View();
        }
        public IActionResult UpdateWorkOut()
        {
            EquiptmentService _EquipmentService = new EquiptmentService();
            ViewBag.Equipments = _EquipmentService.GetAll();
            return View();
        }
        public IActionResult GetAllWorkOut()
        {
            var result = _workOutService.GetAll();
            return Json(result);
        }
        [HttpGet]
        public IActionResult GetWorkOutById(int workoutId)
        {
            WorkOutService _WorkOutService = new WorkOutService();
            var workout = _WorkOutService.GetById(workoutId);
            var result = new { workout };
            return Json(result);
        }
        public void WorkOutTester()
        {
            WorkOutService WorkOutService = new WorkOutService();
            tblWorkOut workout = new tblWorkOut();
            workout.WorkoutName = "TestWO";
            workout.WorkOutDescription = "TestWO";
            workout.DateAdded = DateTime.Now;

            WorkOutService.Add(workout);


        }
        [HttpPost]
        public void InsertWorkOut(tblWorkOut workoutData)
        {
            WorkOutService _WorkOutService = new WorkOutService();
            tblWorkOut workout = new tblWorkOut();
            workout.WorkoutName = workoutData.WorkoutName;
            workout.WorkOutDescription = workoutData.WorkOutDescription;
            workout.DateAdded = DateTime.Now;

            _WorkOutService.Add(workout);
        }

        [HttpPost]
        public IActionResult UpdateWorkOutData(tblWorkOut workoutData)
        {
            WorkOutService _WorkOutService = new WorkOutService();
            var upWorkout = _WorkOutService.Update(workoutData);
            var result = new { upWorkout };
            return Json(result);
        }

        [HttpPost]
        public IActionResult DeleteWorkOut(int workoutId)
        {
            WorkOutService _WorkOutService = new WorkOutService();
            var delWorkout = _WorkOutService.Delete(workoutId);
            var result = new { delWorkout };
            return Json(result);
        }
    }
}
