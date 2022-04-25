using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPlc.EntityFramework.Entity.Dto
{
   public class PlcDto
    {
        public int Id { get; set; }
        public int WorkCenterId { get; set; }
        public string WorkCenterName { get; set; }
        public string Name { get; set; }
        public int Ip{ get; set; }
        public int Slot { get; set; }
        public int ConnType { get; set; }
    }
}
