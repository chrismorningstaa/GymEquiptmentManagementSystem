using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Service
{
    public class WorkOutService
    {
        public WorkOutService() { }
        WorkOutRepos WorkOutRepos = new WorkOutRepos();
        public bool Add(tblWorkOut WorkOut)
        {
            return WorkOutRepos.Add(WorkOut);
        }

        public tblWorkOut GetById(int Id)
        {
            return WorkOutRepos.GetById(Id);
        }

        public bool Update(tblWorkOut WorkOut)
        {
            return WorkOutRepos.Update(WorkOut);
        }

        public tblWorkOut Delete(int Id)
        {
            return WorkOutRepos.Delete(Id);
        }

        public List<tblWorkOut> GetAll()
        {
            return WorkOutRepos.GetAll().ToList();
        }

        public tblWorkOut AddParent(tblWorkOut WorkOut)
        {
            return WorkOutRepos.AddParentAttribute(WorkOut);
        }

    }
}
