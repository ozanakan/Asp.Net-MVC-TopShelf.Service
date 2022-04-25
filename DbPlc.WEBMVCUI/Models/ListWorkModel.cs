using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DbPlc.EntityFramework.Entity;
using DbPlc.EntityFramework.Entity.Dto;

namespace DbPlc.WEBMVCUI.Models
{
    public class ListWorkModel
    {
        public List<WorkCenter> ListWorkCenter { get; set; }
        public List<PlcDto> ListPlcDto { get; set; }

    }
}