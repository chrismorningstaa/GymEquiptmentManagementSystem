using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Service
{
    public  class ClientService
    {
        public ClientService() { }
        ClientRepos ClientRepos = new ();
        public bool Add(tblClient Client)
        {
           return ClientRepos.Add(Client);
        }

        public tblClient GetById(int Id)
        {
            return ClientRepos.GetById(Id);
        }

        public bool Update(tblClient Client)
        {
            return ClientRepos.Update(Client);
        }

        public tblClient Delete(int Id)
        {
            return ClientRepos.Delete(Id);
        }

        public List<tblClient> GetAll()
        {
            return ClientRepos.GetAll().ToList();
        }

        public tblClient AddParent(tblClient Client)
        {
            return ClientRepos.AddParentAttribute(Client);
        }
    }
}
