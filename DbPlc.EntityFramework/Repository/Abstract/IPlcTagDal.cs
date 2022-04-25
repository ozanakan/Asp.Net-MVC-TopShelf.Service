﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbPlc.EntityFramework.Entity;
using DbPlc.EntityFramework.Entity.Dto;

namespace DbPlc.EntityFramework.Repository.Abstract
{
    interface IPlcTagDal:IRepository<PlcTag>
    {
        List<PlcTagDto> GetPlcTagDto();
    }
}
