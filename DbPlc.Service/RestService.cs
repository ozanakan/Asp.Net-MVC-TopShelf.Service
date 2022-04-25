using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace DbPlc.Service
{
    public class RestService
    {
        //private IDisposable _app;
        private ServiceHost srvHost;
        public void Start()
        {
            // _app = WebApp.Start<Startup>("http://localhost:8085");
            srvHost = new ServiceHost(typeof(PlcService));
            //srvHost.AddServiceEndpoint(typeof(IController), new NetHttpBinding(), "http://localhost:8090/DbPlcWeb");
            srvHost.Open();
           
        }

        public void Stop()
        {
            //if (_app != null)
            //    _app.Dispose();
            srvHost.Close();
        }
    }
}
