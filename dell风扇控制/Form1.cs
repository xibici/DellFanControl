using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using dell风扇控制.utils;
using Microsoft.VisualBasic;

namespace dell风扇控制
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static TextBox textBox;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox = textBox1;
            //this.notifyIcon1.Visible = false;
        }

        List<string> statusList = new List<string>() { "未使用","NULL"};

        private void doCMD(string cmdStr) {
            DellFanCmd.ProcessCommand(new string[] { cmdStr });
            //暂时不干活
        }

        private void updateStatus(string ecStatus,string fanSpeedStatus) {
            statusList[0] = ecStatus;
            statusList[1] = fanSpeedStatus;
            toolStripMenuItemStatus.Text = string.Join(" ", statusList);

        }

        string str100 = "fan1-level2";
        string str50 = "fan1-level1";
        string str0 = "fan1-level0";

        string strEcEnable = "ec-enable";
        string strECDisable = "ec-disable";

        private void buttonECDisable_Click(object sender, EventArgs e)
        {
            doCMD(strECDisable);
            label1.Text = "EC已被禁用";
            //label1.
            label1.ForeColor = Color.Red;
            label2.Text = "风扇默认EC禁用模式 100%";

            updateStatus("EC禁用", "100%");
        }

       

        private void buttonECEnable_Click(object sender, EventArgs e)
        {
            doCMD(strEcEnable);
            label1.Text = "EC已恢复启用";
            label1.ForeColor = Color.Green;
            label2.Text = "风扇恢复EC控制";

            updateStatus("EC已恢复", "-");
        }

        private void button100_Click(object sender, EventArgs e)
        {
            doCMD(str100);
            label2.Text = "风扇调至100%";
            updateStatus("EC禁用", "100%");


        }

        private void button50_Click(object sender, EventArgs e)
        {
            doCMD(str50);
            label2.Text = "风扇调至50%";
            updateStatus("EC禁用", "50%");

        }

        private void button0_Click(object sender, EventArgs e)
        {
            doCMD(str0);
            label2.Text = "风扇调至0%";
            updateStatus("EC禁用", "0%");

        }

        #region toolStrip
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //100
            doCMD(str100);
            label2.Text = "风扇调至100%";
            updateStatus("EC禁用", "100%");

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //50
            doCMD(str50);
            label2.Text = "风扇调至50%";
            updateStatus("EC禁用", "50%");

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //0
            doCMD(str0);
            label2.Text = "风扇调至0%";
            updateStatus("EC禁用", "0%");

        }

        private void 禁用ECToolStripMenuItem_Click(object sender, EventArgs e)
        {

            doCMD(strECDisable);
            label1.Text = "EC已被禁用";
            //label1.
            label1.ForeColor = Color.Red;
            label2.Text = "风扇默认EC禁用模式,100%";
            updateStatus("EC禁用", "100%");

        }

        private void 恢复ECToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doCMD(strEcEnable);
            label1.Text = "EC已恢复";
            //label1.
            label1.ForeColor = Color.Green;
            label2.Text = "风扇默认EC禁用模式,100%";
            updateStatus("EC已恢复", "-");

        }
        #endregion


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //注意判断关闭事件Reason来源于窗体按钮，否则用菜单退出时无法退出!
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;    //取消"关闭窗口"事件
                this.WindowState = FormWindowState.Minimized;    //使关闭时窗口向右下角缩小的效果
                notifyIcon1.Visible = true;
                this.Hide();
                return;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();        //可以要，也可以不要，取决于是否隐藏主窗体
                this.notifyIcon1.Visible = true;
            }
          

        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.Hide();        //可以要，也可以不要，取决于是否隐藏主窗体
                    this.WindowState = FormWindowState.Minimized;
                    this.notifyIcon1.Visible = true;
                }
                else if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Show();        //可以要，也可以不要，取决于是否隐藏主窗体
                    this.WindowState = FormWindowState.Normal;
                    //this.notifyIcon1.Visible = true;
                }
            }
           
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void 退出并还原ECToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doCMD(strEcEnable);
            this.notifyIcon1.Visible = false;
            this.Close();
            this.Dispose();
            Application.Exit();

        }

        private void 连接WinSubsystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<object>  tempList = AndroidCmd.connectWinSusbsystem();
            if (!(bool) tempList[0])
            {
                MessageBox.Show(tempList[1].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void useScrcpyJarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AndroidCmd.connectWinSusbsystem();
        }

        private void 连接并UseScrcpyJarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<object> tempList = AndroidCmd.connectWinSusbsystemAndUseScrcpyJar();
            if (!(bool)tempList[0])
            {
                MessageBox.Show(tempList[1].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
