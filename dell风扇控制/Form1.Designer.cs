
namespace dell风扇控制
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonECDisable = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonECEnable = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button100 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.退出并还原ECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.禁用ECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.恢复ECToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.连接WinSubsystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useScrcpyJarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接并UseScrcpyJarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonECDisable
            // 
            this.buttonECDisable.Location = new System.Drawing.Point(437, 43);
            this.buttonECDisable.Name = "buttonECDisable";
            this.buttonECDisable.Size = new System.Drawing.Size(131, 40);
            this.buttonECDisable.TabIndex = 0;
            this.buttonECDisable.Text = "禁用EC";
            this.buttonECDisable.UseVisualStyleBackColor = true;
            this.buttonECDisable.Click += new System.EventHandler(this.buttonECDisable_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(609, 292);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // buttonECEnable
            // 
            this.buttonECEnable.Location = new System.Drawing.Point(632, 43);
            this.buttonECEnable.Name = "buttonECEnable";
            this.buttonECEnable.Size = new System.Drawing.Size(131, 40);
            this.buttonECEnable.TabIndex = 4;
            this.buttonECEnable.Text = "启用EC";
            this.buttonECEnable.UseVisualStyleBackColor = true;
            this.buttonECEnable.Click += new System.EventHandler(this.buttonECEnable_Click);
            // 
            // button50
            // 
            this.button50.Location = new System.Drawing.Point(643, 245);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(131, 40);
            this.button50.TabIndex = 5;
            this.button50.Text = "50%";
            this.button50.UseVisualStyleBackColor = true;
            this.button50.Click += new System.EventHandler(this.button50_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(643, 347);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(131, 40);
            this.button0.TabIndex = 6;
            this.button0.Text = "0%";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button100
            // 
            this.button100.Location = new System.Drawing.Point(643, 151);
            this.button100.Name = "button100";
            this.button100.Size = new System.Drawing.Size(131, 40);
            this.button100.TabIndex = 7;
            this.button100.Text = "100%";
            this.button100.UseVisualStyleBackColor = true;
            this.button100.Click += new System.EventHandler(this.button100_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "123";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStatus,
            this.退出并还原ECToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.禁用ECToolStripMenuItem,
            this.恢复ECToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.连接WinSubsystemToolStripMenuItem,
            this.useScrcpyJarToolStripMenuItem,
            this.连接并UseScrcpyJarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(280, 416);
            // 
            // toolStripMenuItemStatus
            // 
            this.toolStripMenuItemStatus.Enabled = false;
            this.toolStripMenuItemStatus.Name = "toolStripMenuItemStatus";
            this.toolStripMenuItemStatus.Size = new System.Drawing.Size(279, 34);
            this.toolStripMenuItemStatus.Text = "状态";
            // 
            // 退出并还原ECToolStripMenuItem
            // 
            this.退出并还原ECToolStripMenuItem.Name = "退出并还原ECToolStripMenuItem";
            this.退出并还原ECToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.退出并还原ECToolStripMenuItem.Text = "退出并还原EC";
            this.退出并还原ECToolStripMenuItem.Click += new System.EventHandler(this.退出并还原ECToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.退出ToolStripMenuItem.Text = "直接退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 禁用ECToolStripMenuItem
            // 
            this.禁用ECToolStripMenuItem.Name = "禁用ECToolStripMenuItem";
            this.禁用ECToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.禁用ECToolStripMenuItem.Text = "禁用EC";
            this.禁用ECToolStripMenuItem.Click += new System.EventHandler(this.禁用ECToolStripMenuItem_Click);
            // 
            // 恢复ECToolStripMenuItem
            // 
            this.恢复ECToolStripMenuItem.Name = "恢复ECToolStripMenuItem";
            this.恢复ECToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.恢复ECToolStripMenuItem.Text = "恢复EC";
            this.恢复ECToolStripMenuItem.Click += new System.EventHandler(this.恢复ECToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(279, 34);
            this.toolStripMenuItem2.Text = "100%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(279, 34);
            this.toolStripMenuItem3.Text = "50%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(279, 34);
            this.toolStripMenuItem4.Text = "0%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 连接WinSubsystemToolStripMenuItem
            // 
            this.连接WinSubsystemToolStripMenuItem.Name = "连接WinSubsystemToolStripMenuItem";
            this.连接WinSubsystemToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.连接WinSubsystemToolStripMenuItem.Text = "连接Win subsystem";
            this.连接WinSubsystemToolStripMenuItem.Click += new System.EventHandler(this.连接WinSubsystemToolStripMenuItem_Click);
            // 
            // useScrcpyJarToolStripMenuItem
            // 
            this.useScrcpyJarToolStripMenuItem.Name = "useScrcpyJarToolStripMenuItem";
            this.useScrcpyJarToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.useScrcpyJarToolStripMenuItem.Text = "UseScrcpyJar";
            this.useScrcpyJarToolStripMenuItem.Visible = false;
            this.useScrcpyJarToolStripMenuItem.Click += new System.EventHandler(this.useScrcpyJarToolStripMenuItem_Click);
            // 
            // 连接并UseScrcpyJarToolStripMenuItem
            // 
            this.连接并UseScrcpyJarToolStripMenuItem.Name = "连接并UseScrcpyJarToolStripMenuItem";
            this.连接并UseScrcpyJarToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.连接并UseScrcpyJarToolStripMenuItem.Text = "连接并UseScrcpyJar";
            this.连接并UseScrcpyJarToolStripMenuItem.Visible = false;
            this.连接并UseScrcpyJarToolStripMenuItem.Click += new System.EventHandler(this.连接并UseScrcpyJarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button100);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button50);
            this.Controls.Add(this.buttonECEnable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonECDisable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonECDisable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonECEnable;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button100;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 禁用ECToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 恢复ECToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 退出并还原ECToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStatus;
        private System.Windows.Forms.ToolStripMenuItem 连接WinSubsystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useScrcpyJarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接并UseScrcpyJarToolStripMenuItem;
    }
}

