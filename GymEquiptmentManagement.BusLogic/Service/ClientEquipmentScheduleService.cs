using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Service
{
    public class ClientEquipmentScheduleService
    {
        public ClientEquipmentScheduleService() { }
        ClientEquipmentScheduleRepos ClientEquipmentScheduleRepos = new ClientEquipmentScheduleRepos();
        public bool Add(tblClientEquipmentSchedule ClientEquipmentSchedule)
        {
            return ClientEquipmentScheduleRepos.Add(ClientEquipmentSchedule);
        }

        public tblClientEquipmentSchedule GetById(int Id)
        {
            return ClientEquipmentScheduleRepos.GetById(Id);
        }

        public bool Update(tblClientEquipmentSchedule ClientEquipmentSchedule)
        {
            return ClientEquipmentScheduleRepos.Update(ClientEquipmentSchedule);
        }

        public List<tblClientEquipmentSchedule> GetAll()
        {
            return ClientEquipmentScheduleRepos.GetAll().ToList();
        }
    }
}
