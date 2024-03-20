using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Service
{
    public class WorkOutDetailService
    {
        public WorkOutDetailService() { }
        WorkOutDetailRepos WorkOutDetailRepos = new WorkOutDetailRepos();
        public bool Add(tblWorkOutDetail WorkOutDetail)
        {
            return WorkOutDetailRepos.Add(WorkOutDetail);
        }

        public tblWorkOutDetail GetById(int Id)
        {
            return WorkOutDetailRepos.GetById(Id);
        }

        public bool Update(tblWorkOutDetail WorkOutDetail)
        {
            return WorkOutDetailRepos.Update(WorkOutDetail);
        }

        public List<tblWorkOutDetail> GetAll()
        {
            return WorkOutDetailRepos.GetAll().ToList();
        }
    }
}
