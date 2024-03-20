using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Service
{
    public class WorkOutPlanDetailService
    {
        public WorkOutPlanDetailService() { }
        WorkOutPlanDetailRepos WorkOutPlanDetailRepos = new WorkOutPlanDetailRepos();
        public bool Add(tblWorkOutPlanDetail WorkOutPlanDetail)
        {
            return WorkOutPlanDetailRepos.Add(WorkOutPlanDetail);
        }

        public tblWorkOutPlanDetail GetById(int Id)
        {
            return WorkOutPlanDetailRepos.GetById(Id);
        }

        public bool Update(tblWorkOutPlanDetail WorkOutPlanDetail)
        {
            return WorkOutPlanDetailRepos.Update(WorkOutPlanDetail);
        }

        public List<tblWorkOutPlanDetail> GetAll()
        {
            return WorkOutPlanDetailRepos.GetAll().ToList();
        }
    }
}
