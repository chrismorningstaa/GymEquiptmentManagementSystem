using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace GymEquiptmentManagement.Web.Controllers
{
    public class WorkOutPlanController : Controller
    {
        private WorkOutPlanService _workOutPlanService = new WorkOutPlanService();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddNewWorkOutPlan()
        {
            WorkOutService _WorkOutService = new WorkOutService();
            ViewBag.Workout = _WorkOutService.GetAll();
            return View();
        }
        public IActionResult UpdateWorkOutPlan()
        {
            WorkOutService _WorkOutService = new WorkOutService();
            ViewBag.Workout = _WorkOutService.GetAll();
            return View();
        }
        public IActionResult GetAllWorkOutPlan()
        {
            var result = _workOutPlanService.GetAll();
            return Json(result);
        }

        [HttpGet]
        public IActionResult GetWorkOutPlanById(int workoutplanId)
        {
            WorkOutPlanService _WorkOutPlanService = new WorkOutPlanService();
            var workoutplan = _WorkOutPlanService.GetById(workoutplanId);
            var result = new { workoutplan };
            return Json(result);
        }

        public void WorkOutPlanTester()
        {
            WorkOutPlanService WorkOutPlanService = new WorkOutPlanService();
            tblWorkOutPlan workoutPlan = new tblWorkOutPlan();
            workoutPlan.WorkOutPlanName = "TestWOP";
            workoutPlan.WorkOutPlanDescription = "TestWOP";
            workoutPlan.Price = 10;
            workoutPlan.DateAdded = DateTime.Now;

            WorkOutPlanService.Add(workoutPlan);


        }

        [HttpPost]
        public int InsertWorkOutPlan(tblWorkOutPlan workoutplanData)
        {
            WorkOutPlanService _WorkOutPlanService = new WorkOutPlanService();
            tblWorkOutPlan workoutplan = new tblWorkOutPlan();
            workoutplan.WorkOutPlanName = workoutplanData.WorkOutPlanName;
            workoutplan.WorkOutPlanDescription = workoutplanData.WorkOutPlanDescription;
            workoutplan.Price = workoutplanData.Price;
            workoutplan.DateAdded = DateTime.Now;

            _WorkOutPlanService.Add(workoutplan);

            return workoutplanData.Id;
        }

        [HttpPost]
        public IActionResult UpdateWorkOutPlanData(tblWorkOutPlan workoutplanData)
        {
            WorkOutPlanService _WorkOutPlanService = new WorkOutPlanService();
            var upWorkoutplan = _WorkOutPlanService.Update(workoutplanData);
            var result = new { upWorkoutplan };
            return Json(result);
        }

        [HttpPost]
        public IActionResult DeleteWorkOutPlan(int workoutplanId)
        {
            WorkOutPlanService _WorkOutPlanService = new WorkOutPlanService();
            var delWorkoutPlan = _WorkOutPlanService.Delete(workoutplanId);
            var result = new { delWorkoutPlan };
            return Json(result);
        }
    }
}
