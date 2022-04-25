using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DbPlc.EntityFramework.Entity;
using DbPlc.EntityFramework.Entity.Dto;
namespace DbPlc.WEBMVCUI.Models
{
    public class ListViewModel
    {
        public List<Area> ListArea { set; get; }
        public List<WorkCenterDto>LIstWorkCenterDto { get; set; }

    }
}