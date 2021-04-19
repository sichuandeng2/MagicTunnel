namespace TunnelCode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBoxMstsc = new System.Windows.Forms.PictureBox();
            this.pictureBoxWeb = new System.Windows.Forms.PictureBox();
            this.labelMstsc = new System.Windows.Forms.Label();
            this.labelWeb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMstsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeb)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(63, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "运行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(211, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Location = new System.Drawing.Point(63, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 32);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBoxMstsc
            // 
            this.pictureBoxMstsc.ImageLocation = "";
            this.pictureBoxMstsc.Location = new System.Drawing.Point(73, 85);
            this.pictureBoxMstsc.Name = "pictureBoxMstsc";
            this.pictureBoxMstsc.Size = new System.Drawing.Size(78, 60);
            this.pictureBoxMstsc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMstsc.TabIndex = 4;
            this.pictureBoxMstsc.TabStop = false;
            // 
            // pictureBoxWeb
            // 
            this.pictureBoxWeb.ImageLocation = "";
            this.pictureBoxWeb.Location = new System.Drawing.Point(221, 85);
            this.pictureBoxWeb.Name = "pictureBoxWeb";
            this.pictureBoxWeb.Size = new System.Drawing.Size(78, 60);
            this.pictureBoxWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWeb.TabIndex = 5;
            this.pictureBoxWeb.TabStop = false;
            // 
            // labelMstsc
            // 
            this.labelMstsc.AutoSize = true;
            this.labelMstsc.Font = new System.Drawing.Font("宋体", 12F);
            this.labelMstsc.Location = new System.Drawing.Point(84, 171);
            this.labelMstsc.Name = "labelMstsc";
            this.labelMstsc.Size = new System.Drawing.Size(56, 16);
            this.labelMstsc.TabIndex = 6;
            this.labelMstsc.Text = "已关闭";
            // 
            // labelWeb
            // 
            this.labelWeb.AutoSize = true;
            this.labelWeb.Font = new System.Drawing.Font("宋体", 12F);
            this.labelWeb.Location = new System.Drawing.Point(232, 171);
            this.labelWeb.Name = "labelWeb";
            this.labelWeb.Size = new System.Drawing.Size(56, 16);
            this.labelWeb.TabIndex = 7;
            this.labelWeb.Text = "已关闭";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 262);
            this.Controls.Add(this.labelWeb);
            this.Controls.Add(this.labelMstsc);
            this.Controls.Add(this.pictureBoxWeb);
            this.Controls.Add(this.pictureBoxMstsc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "隧道启动程序";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMstsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBoxMstsc;
        private System.Windows.Forms.PictureBox pictureBoxWeb;
        private System.Windows.Forms.Label labelMstsc;
        private System.Windows.Forms.Label labelWeb;
        private System.Windows.Forms.Timer timer1;
    }
}

