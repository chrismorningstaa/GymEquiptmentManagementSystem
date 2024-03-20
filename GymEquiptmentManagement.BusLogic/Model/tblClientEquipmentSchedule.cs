using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Model
{
    public class tblClientEquipmentSchedule
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }

        public int EquiptmentId { get; set; }
        public DateTime DateReserved { get; set; }
        public TimeSpan TimeReserved { get; set; }
        public int IsActive { get; set; }
    }
}
