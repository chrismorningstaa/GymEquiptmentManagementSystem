﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymEquiptmentManagement.BusLogic.Model
{
    public class tblWorkOutDetail
    {
        [Key]
        public int Id { get; set; }
        public int WorkOutId { get; set; }
        public int EquiptmentId { get; set; }
        public int NoOfRepititionId { get; set; }

    }
}
