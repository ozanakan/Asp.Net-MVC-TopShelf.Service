using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPlc.EntityFramework
{
   public class Connection
    {
        private const string ConString = "Server=DESKTOP-PU7I8L5;database=DbPlc;trusted_connection=true;Integrated Security=TRUE;MultipleActiveResultSets = true";
        public SqlConnection connection = new SqlConnection(ConString);
    }
}
