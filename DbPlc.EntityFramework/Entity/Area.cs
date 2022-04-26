﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DbPlc.EntityFramework.Entity
{ 
   public class Area
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //[ForeignKey("AreaId")]
        //public virtual ICollection<WorkCenter> WorkCenters { get; set; }
    }
}
