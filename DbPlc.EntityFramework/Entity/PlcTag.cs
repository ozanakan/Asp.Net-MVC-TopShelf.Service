using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPlc.EntityFramework.Entity
{
    public class PlcTag
    {
        //     public int Id { get; set; }
        [Key]
        public int Id { get; set; }
        public int PlcId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DbNumber { get; set; }
        public int Address { get; set; }
        public int DataType { get; set; }

    }
}
