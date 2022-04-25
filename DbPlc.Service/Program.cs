using System;

using Topshelf;

namespace DbPlc.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                x.Service<RestService>(s =>
                {
                    s.ConstructUsing(() => new RestService());
                    s.WhenStarted(rs => rs.Start());
                    s.WhenStopped(rs => rs.Stop());
                    //s.WhenShutdown(rs => rs.Stop());
                });
                x.RunAsLocalSystem();
                x.StartAutomatically();
                x.SetServiceName("DbPlc.Service");
                x.SetDisplayName("DbPlc.Service");
                x.SetDescription("Windows Hosted Web Service.");

            });
        }
    }
}