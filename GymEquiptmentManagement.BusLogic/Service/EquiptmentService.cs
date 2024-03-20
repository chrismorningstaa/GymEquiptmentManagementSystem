using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Service
{
    public class EquiptmentService
    {
        public EquiptmentService() { }
        EquiptmentRepos EquiptmentRepos = new EquiptmentRepos();
        public bool Add(tblEquiptment Equiptment)
        {
            return EquiptmentRepos.Add(Equiptment);
        }

        public tblEquiptment GetById(int Id)
        {
            return EquiptmentRepos.GetById(Id);
        }

        public bool Update(tblEquiptment Equiptment)
        {
            return EquiptmentRepos.Update(Equiptment);
        }

        public tblEquiptment Delete(int Id)
        {
            return EquiptmentRepos.Delete(Id);
        }

        public List<tblEquiptment> GetAll()
        {
            return EquiptmentRepos.GetAll().ToList();
        }
    }
}
