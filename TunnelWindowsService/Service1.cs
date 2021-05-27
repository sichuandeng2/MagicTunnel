using MagicTunnBll;
using System;
using System.Configuration;
using System.Linq;
using System.ServiceProcess;

namespace TunnelWindowsService
{
    public partial class Service1 : ServiceBase
    {
        //获取当前启动路径
        public readonly static string curDic = AppDomain.CurrentDomain.BaseDirectory;

        //获取服务信息
        private readonly static string serverInfo = ConfigurationManager.AppSettings.Get("serverInfo");

        TunnelBll tb = new TunnelBll(serverInfo, curDic);
        //List<Process> MagicProcess = new List<Process>();
        public Service1()
        {
            InitializeComponent();
        }
        // 调试运行
        public void OnDebug()
        {
            string[] str = { "" };
            object serder = null;
            System.Timers.ElapsedEventArgs e = null;
            timer1_Elapsed(serder, e);

            OnStart(str);
            timer1_Elapsed(serder, e);

            OnStop();
            timer1_Elapsed(serder, e);

        }

        protected override void OnStart(string[] args)
        {
            foreach (string item in tb.GetServeNameList().ToArray<string>())
            {
                tb.CreatProcess(item);
            }
        }

        protected override void OnStop()
        {
            foreach (string item in tb.GetServeNameList().ToArray<string>())
            {
                tb.DeleteProcess(item);
            }
            timer1.Stop();
            timer1.Dispose();
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            tb.UpdateCurrentEnableProcess();
            //tb.CloseServe();
            //OnStop();
        }
    }
}
