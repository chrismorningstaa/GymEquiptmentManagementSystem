using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Model
{
    public class tblWorkOut
    {
        [Key]
        public int Id { get; set; }
        public string WorkoutName { get; set; }
        public string WorkOutDescription { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
