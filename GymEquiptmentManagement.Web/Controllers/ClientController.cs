using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace GymEquiptmentManagement.Web.Controllers
{
    public class ClientController : Controller
    {
        private ClientService _clientService = new ClientService();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddNewClient()
        {
            return View();
        }

        public IActionResult UpdateClient()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetClientById(int clientId, int userId)
        {
            ClientService _ClientService = new ClientService();
            UserService _UserService = new UserService();
            var client = _ClientService.GetById(clientId);
            var user = _UserService.GetById(userId);
            var result = new { client, user };
            return Json(result);
        }

        public void ClientTester()
        {
            ClientService ClientService = new ClientService();
            tblClient client = new tblClient();
            client.FirstName = "Test";
            client.LastName = "Last";
            client.ClientUniqueId = "Unique";
            client.BirthDate = DateTime.Now;
            client.Gender = "M";

            var c = ClientService.AddParent(client);
            UserService UserService = new UserService();
            tblUser user = new tblUser();
            user.ClientId = c.Id;
            user.UserName = "MyUserName";
            user.Password = "PW";
            user.Email = "Email";
            user.IsActive = 1;

            UserService.Add(user);

            ClientBMIService ClientBMService = new ClientBMIService();
            tblClientBMI tblClientBMI = new tblClientBMI();
            tblClientBMI.ClientId = c.Id;
            tblClientBMI.Weight = 100;
            tblClientBMI.Height = 50;
            tblClientBMI.BMI = 12;
            tblClientBMI.DateAdded = DateTime.Now;
            ClientBMService.Add(tblClientBMI);

        }
        public IActionResult GetAllClient()
        {
            var result = _clientService.GetAll();
            return Json(result);
        }

        [HttpPost]
        public int InsertClient(tblClient clientData, tblUser userData )
        {
            ClientService ClientService = new ClientService();
            tblClient client = new tblClient();
            client.FirstName = clientData.FirstName;
            client.LastName = clientData.LastName;
            client.ClientUniqueId = "Unique";
            client.BirthDate = clientData.BirthDate;
            client.Gender = clientData.Gender;

            var c = ClientService.AddParent(client);
            UserService UserService = new UserService();
            tblUser user = new tblUser();
            user.ClientId = c.Id;
            user.UserName = userData.UserName;
            user.Password = userData.Password;
            user.Email = userData.Email;
            user.UserType = userData.UserType; 
            user.IsActive = 1;

            UserService.Add(user);

            return c.Id;

        }
        [HttpPost]
        public IActionResult UpdateClientData(tblClient clientData, tblUser userData)
        {
            ClientService _ClientService = new ClientService();
            UserService _UserService = new UserService();
            var upClient = _ClientService.Update(clientData);
            var upUser = _UserService.Update(userData);
            var result = new { upClient, upUser };
            return Json(result);
        }

        [HttpPost]
        public IActionResult DeleteClient(int clientId)
        {
            ClientService ClientService = new ClientService();
            var delClient = ClientService.Delete(clientId);
            var result = new { delClient };
            return Json(result);
        }
    }
}
