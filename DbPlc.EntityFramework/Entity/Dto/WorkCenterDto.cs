using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPlc.EntityFramework.Entity.Dto
{
    public class WorkCenterDto
    {
        public int Id { get; set; }  
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
