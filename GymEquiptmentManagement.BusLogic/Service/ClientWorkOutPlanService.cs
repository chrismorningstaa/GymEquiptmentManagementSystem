using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Service
{
    public class ClientWorkOutPlanService
    {
        public ClientWorkOutPlanService() { }
        ClientWorkOutPlanRepos ClientWorkOutPlanRepos = new ClientWorkOutPlanRepos();
        public bool Add(tblClientWorkoutPlan ClientWorkOutPlan)
        {
            return ClientWorkOutPlanRepos.Add(ClientWorkOutPlan);
        }

        public tblClientWorkoutPlan GetById(int Id)
        {
            return ClientWorkOutPlanRepos.GetById(Id);
        }

        public bool Update(tblClientWorkoutPlan ClientWorkOutPlan)
        {
            return ClientWorkOutPlanRepos.Update(ClientWorkOutPlan);
        }

        public List<tblClientWorkoutPlan> GetAll()
        {
            return ClientWorkOutPlanRepos.GetAll().ToList();
        }
    }
}
