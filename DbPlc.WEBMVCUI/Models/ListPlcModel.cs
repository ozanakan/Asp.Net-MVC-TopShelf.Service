using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DbPlc.EntityFramework.Entity;
using DbPlc.EntityFramework.Entity.Dto;

namespace DbPlc.WEBMVCUI.Models
{
    public class ListPlcModel
    {
        public List<Plc> ListPlc { get; set; }
        public List<PlcTagDto>ListPlcTagDto { get; set; }

    }
}