using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Model
{
    public class tblEquiptment
    {
        [Key]
        public int Id { get; set; }
        public string EquiptmentName { get; set; }
        public string EquiptmentDescription { get; set; }
        public int MaxReserveTimeMinute { get; set; }
        public DateTime DateAdded { get; set; }
        public string ImageSource { get; set; }

    }
}
