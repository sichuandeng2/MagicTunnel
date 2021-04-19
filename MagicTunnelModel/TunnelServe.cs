using System;
using System.Diagnostics;
using System.IO;

namespace MagicTunnelModel
{
    public class TunnelServe
    {
        //服务名称
        public string ServeName { get; set; }
        //秘钥
        public string Token { set; get; }
        //当前进程
        public Process ServeProcess { get; set; }

        //进程的状态
        public Boolean Enable { get; set; }
       public TunnelServe(string serverName,string token )
        {
            this.ServeName = serverName;
            this.Token = token;

        }

        public void CreatProcess(string curDic,Boolean debug)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = $"{ServeName}.exe",
                CreateNoWindow = !debug,
                WorkingDirectory = Path.Combine(curDic),
                Arguments = Token
            };
            ServeProcess = Process.Start(startInfo);
            Enable = true;
        }

        public void DeleteProcess()
        {
            try
            {
                //ServeProcess.Close();
                ServeProcess.Kill();
                ServeProcess.Dispose();
                Enable = false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 检测当前文件是否存在
        /// </summary>
        /// <param name="filePath">需要检测的文件路径</param>
        /// <returns></returns>
        public static Boolean CheckFileExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return false;
            }
            return true;
        }
    }
}
