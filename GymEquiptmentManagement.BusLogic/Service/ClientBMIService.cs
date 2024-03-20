using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Service
{
    public class ClientBMIService
    {
        public ClientBMIService() { }
        ClientBMIRepos ClientBMIRepos = new ClientBMIRepos();
        public bool Add(tblClientBMI ClientBMI)
        {
            return ClientBMIRepos.Add(ClientBMI);
        }

        public tblClientBMI GetById(int Id)
        {
            return ClientBMIRepos.GetById(Id);
        }

        public bool Update(tblClientBMI ClientBMI)
        {
            return ClientBMIRepos.Update(ClientBMI);
        }

        public List<tblClientBMI> GetAll()
        {
            return ClientBMIRepos.GetAll().ToList();
        }
    }
}
