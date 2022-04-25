using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPlc.EntityFramework.Entity
{
    public class WorkCenter
    {
        [Key]
        public int Id { get; set; }
        public int AreaId { get; set; }
        public string Name { get; set; }

        //[Required(ErrorMessage = "Description cannot be blank.")]
        public string Description { get; set; }
     
        // public List<Area>Areas { get; set; }
        //[ForeignKey("Id")]
        //public virtual Area Area { get; set; }
        //[ForeignKey("WorkCenterId")]
        //public virtual ICollection<Plc> Plcs { get; set; }
    }
}
