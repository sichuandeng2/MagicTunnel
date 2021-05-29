using MagicTunnBll;
using System.Linq;
using System.ServiceProcess;
using TunnelCode;

namespace TunnelWindowsService
{
    public partial class Service1: ServiceBase
    {
        //获取当前启动路径
        private readonly static string curDic = Form1.curDic;

        //获取服务信息
        private readonly static string serverInfo = Form1.serverInfo;

        TunnelBll tb = new TunnelBll(serverInfo, curDic);
        public Service1( )
        {
            InitializeComponent( );
        }
        // 调试运行
        public void OnDebug( )
        {
            string[] str = {""};
            object serder = null;
            System.Timers.ElapsedEventArgs e = null;
            timer1_Elapsed(serder, e);

            OnStart(str);
            timer1_Elapsed(serder, e);

            OnStop( );
            timer1_Elapsed(serder, e);

        }

        protected override void OnStart(string[] args)
        {
            foreach (string item in tb.GetServeNameList( ).ToArray<string>( ))
            {
                tb.CreatProcess(item);
            }
        }

        protected override void OnStop( )
        {
            foreach (string item in tb.GetServeNameList( ).ToArray<string>( ))
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
