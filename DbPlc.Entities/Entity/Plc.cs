using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPlc.EntityFramework.Entity
{
    public class Plc
    {
        [Key]
        public int Id { get; set; }

        public int WorkCenterId { get; set; }
        public string Name { get; set; }
        public int Ip { get; set; }
        public int Slot { get; set; }
        public int ConnType { get; set; }
        //public List<WorkCenter> WorkCenters { get; set; }
    
        
        //[ForeignKey("Id")]
        //public virtual WorkCenter WorkCenter { get; set; }
        //[ForeignKey("PlcId")]
        //public virtual ICollection<PlcTag> PlcTags { get; set; }
    }
}
