using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TunnelWindowsService
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
#if DEBUG
            Service1 DebugServe = new Service1();
            DebugServe.OnDebug();
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
                
#endif
        }
    }
}
