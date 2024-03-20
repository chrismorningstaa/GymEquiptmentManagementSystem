 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Model
{
    public class tblClientWorkoutPlan
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int WorkOutPlanId { get; set; }
        public int IsActive { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
