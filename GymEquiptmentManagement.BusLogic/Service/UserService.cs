using GymEquiptmentManagement.BusLogic.Model;
using GymEquiptmentManagement.BusLogic.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Service
{
    public class UserService
    {
        public UserService() { }
       UserRepos UserRepos = new UserRepos();
        public bool Add(tblUser User)
        {
            return UserRepos.Add(User);
        }

        public tblUser GetById(int Id)
        {
            return UserRepos.GetById(Id);
        }

        public bool Update(tblUser User)
        {
            return UserRepos.Update(User);
        }

        public List<tblUser> GetAll()
        {
            return UserRepos.GetAll().ToList();
        }
    }
}
