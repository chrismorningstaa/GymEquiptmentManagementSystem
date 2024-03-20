using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Model
{
    public class tblClientBMI
    {
        [Key]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public float BMI { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
