using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DbPlc.Service
{
    [DataContract]
    public class ResponseError
    {
        public ResponseError(string message)
        {
            this.ErrorMessage = message;
        }

        [DataMember]
        public string ErrorMessage { get; set; }
    }
}
