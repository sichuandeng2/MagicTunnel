using MagicTunnBll;
using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TunnelCode
{
    public partial class Form1 : Form
    {
       
        //当前服务名称
        public string ServerNmae { get; set; }
        //获取当前启动路径
        public static string curDic { 
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;
            } 
        }
        //获取服务信息
        public static string serverInfo
        {
            get
            {
               return ConfigurationManager.AppSettings.Get("serverInfo");
            }
        }
        //是否启动调试模式
        private static Boolean EnableDeBug
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings.Get("debug"));
            }
        }

        TunnelBll tunnelBll = new TunnelBll(serverInfo, curDic, EnableDeBug);
        //TunnelServe tunnelServe = new TunnelServe();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tunnelBll.CreatProcess(ServerNmae);
            BindIconAndEnable();
            UpDateButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tunnelBll.DeleteProcess(ServerNmae);
            BindIconAndEnable();
            UpDateButton();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(tunnelBll.GetServeNameList().ToArray<string>());
            comboBox1.SelectedIndex = 0;
            ServerNmae = comboBox1.SelectedItem.ToString();
            BindIconAndEnable();
            UpDateButton();
        }
        /// <summary>
        /// 切换服务端口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServerNmae = comboBox1.SelectedItem.ToString();
            UpDateButton();
        }

        private void BindIconAndEnable()
        {
            foreach (var item in tunnelBll.ServeList)
            {
                if (item.ServeName == "mstsc")
                {
                    if (item.Enable)
                    {
                        pictureBoxMstsc.Image = Image.FromFile(Path.Combine(curDic, "images", $"mstscGreen.png"));
                        labelMstsc.Text = "正在运行";
                        labelMstsc.ForeColor = Color.Green;
                    }
                    else
                    {
                        pictureBoxMstsc.Image = Image.FromFile(Path.Combine(curDic, "images", $"mstscBlack.png"));
                        labelMstsc.Text = "已关闭";
                        labelMstsc.ForeColor = Color.Black;
                    }
                }
                if(item.ServeName == "web")
                {
                    if (item.Enable)
                    {
                        pictureBoxWeb.Image = Image.FromFile(Path.Combine(curDic, "images", $"webGreen.png"));
                        labelWeb.Text = "正在运行";
                        labelWeb.ForeColor = Color.Green;
                    }
                    else
                    {
                        pictureBoxWeb.Image = Image.FromFile(Path.Combine(curDic, "images", $"webBlack.png"));
                        labelWeb.Text = "已关闭";
                        labelWeb.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void UpDateButton()
        {
            foreach (var item in tunnelBll.ServeList)
            {
                if (ServerNmae == item.ServeName)
                {
                    if (item.Enable)
                    {
                        button1.Enabled = false;
                        button2.Enabled = true;
                    }
                    else
                    {
                        button1.Enabled = true;
                        button2.Enabled = false;
                    }
                }
            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            tunnelBll.UpdateCurrentEnableProcess();
            BindIconAndEnable();
        }
    }
}
