using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Service
{
    public class WorkOutPlanService
    {
        public WorkOutPlanService() { }
        WorkOutPlanRepos WorkOutPlanRepos = new WorkOutPlanRepos();
        public bool Add(tblWorkOutPlan WorkOutPlan)
        {
            return WorkOutPlanRepos.Add(WorkOutPlan);
        }

        public tblWorkOutPlan GetById(int Id)
        {
            return WorkOutPlanRepos.GetById(Id);
        }

        public bool Update(tblWorkOutPlan WorkOutPlan)
        {
            return WorkOutPlanRepos.Update(WorkOutPlan);
        }

        public tblWorkOutPlan Delete(int Id)
        {
            return WorkOutPlanRepos.Delete(Id);
        }

        public List<tblWorkOutPlan> GetAll()
        {
            return WorkOutPlanRepos.GetAll().ToList();
        }

        public tblWorkOutPlan AddParent(tblWorkOutPlan WorkOutPlan)
        {
            return WorkOutPlanRepos.AddParentAttribute(WorkOutPlan);
        }
    }
}
