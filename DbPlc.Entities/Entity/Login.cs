using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPlc.EntityFramework.Entity
{
    public class Login
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Password { set; get; }
    }
}
