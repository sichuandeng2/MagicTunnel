using MagicTunnelModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace MagicTunnBll
{
    public class TunnelBll
    {

        private List<TunnelServe> serveList = new List<TunnelServe>();

        public List<TunnelServe> ServeList
        {
            get => this.serveList;
        }

        //当前路径
        public string CurDic { get; }

        public Boolean EnableDebug { get; }

        public TunnelBll(string serveInfo,string curDic, bool enableDebug =false )
        {
            string[] serversInfo = serveInfo.Split(',');
            for (int i = 0; i < serversInfo.Length; i++)
            {
                string[] serve = serversInfo[i].Split(':');
                string filePath = Path.Combine(curDic, serve[0] + ".exe");
                string blackImg = Path.Combine(curDic,"images", serve[0] + "Black.png");
                string greenImg = Path.Combine(curDic, "images", serve[0] + "Green.png");
                if (!TunnelServe.CheckFileExists(filePath))
                {
                    new Exception($"文件{ filePath }丢失");
                }
                if (!TunnelServe.CheckFileExists(blackImg))
                {
                    new Exception($"文件{ blackImg }丢失");
                }
                if (!TunnelServe.CheckFileExists(greenImg))
                {
                    new Exception($"文件{ greenImg }丢失");
                }
                serveList.Add(new TunnelServe(serve[0], serve[1]));
               
            }
            UpdateCurrentEnableProcess();
            this.CurDic = curDic;
            this.EnableDebug = enableDebug;
        }

        public IEnumerable<string> GetServeNameList()
        {
            List<string> serveNameList = new List<string>();
            foreach (TunnelServe item in serveList)
            {
                serveNameList.Add(item.ServeName);
            }
            return serveNameList;
        }

        public void UpdateCurrentEnableProcess()
        {
            foreach (var item in ServeList)
            {
                Process[] processes = Process.GetProcessesByName(item.ServeName);
                if (processes.Length == 1)
                {
                    if (item.Enable==null || !processes[0].HasExited)
                    {
                        item.ServeProcess = processes[0];
                    }
                    else
                    {
                        new Exception($"{item.ServeName}进程已经存在");
                    }
                    item.Enable = true;
                    
                }
                else
                {
                    item.Enable = false;
                }
            }
        }

        public void CreatProcess(string serveName)
        {
            TunnelServe tsByName = ServeList.First(ts => ts.ServeName == serveName);
            tsByName.CreatProcess(CurDic, EnableDebug);
        }

        public void DeleteProcess(string serveName)
        {
            TunnelServe tsByName = ServeList.First(ts => ts.ServeName == serveName);
            tsByName.DeleteProcess();
        }

        /// <summary>
        /// 关闭服务
        /// </summary>
        public void CloseServe()
        {
            foreach (var item in ServeList)
            {
                if (!item.Enable)
                {
                    item.DeleteProcess();
                }
            }
        }
    }
}
