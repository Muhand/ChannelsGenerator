namespace ChannelsGenerator
{
    partial class ChannelsGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChannelsGenerator));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.player = new AxAXVLC.AxVLCPlugin2();
            this.progress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.settingsGbx = new System.Windows.Forms.GroupBox();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputMama = new System.Windows.Forms.RadioButton();
            this.outputM3u = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputChan = new System.Windows.Forms.RadioButton();
            this.inputM3u = new System.Windows.Forms.RadioButton();
            this.generateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputFileName = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dirName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearLog = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.previewer = new AxAXVLC.AxVLCPlugin2();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.settingsGbx.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 780);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.player);
            this.tabPage1.Controls.Add(this.progress);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.settingsGbx);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 751);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(309, 229);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(18, 18);
            this.player.TabIndex = 5;
            this.player.Visible = false;
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Location = new System.Drawing.Point(3, 727);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(0, 17);
            this.progress.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 697);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(919, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(3, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 570);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Channels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Verified Channels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "All Channels";
            // 
            // listBox2
            // 
            this.listBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(461, 50);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(455, 516);
            this.listBox2.TabIndex = 2;
            this.listBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 56);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(455, 516);
            this.listBox1.TabIndex = 1;
            // 
            // settingsGbx
            // 
            this.settingsGbx.Controls.Add(this.verifyBtn);
            this.settingsGbx.Controls.Add(this.groupBox2);
            this.settingsGbx.Controls.Add(this.groupBox1);
            this.settingsGbx.Controls.Add(this.generateBtn);
            this.settingsGbx.Controls.Add(this.label2);
            this.settingsGbx.Controls.Add(this.outputFileName);
            this.settingsGbx.Controls.Add(this.browseBtn);
            this.settingsGbx.Controls.Add(this.label1);
            this.settingsGbx.Controls.Add(this.dirName);
            this.settingsGbx.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsGbx.Location = new System.Drawing.Point(3, 3);
            this.settingsGbx.Name = "settingsGbx";
            this.settingsGbx.Size = new System.Drawing.Size(922, 122);
            this.settingsGbx.TabIndex = 3;
            this.settingsGbx.TabStop = false;
            this.settingsGbx.Text = "Settings";
            // 
            // verifyBtn
            // 
            this.verifyBtn.Enabled = false;
            this.verifyBtn.Location = new System.Drawing.Point(566, 54);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(172, 62);
            this.verifyBtn.TabIndex = 11;
            this.verifyBtn.Text = "Verify Channels";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputMama);
            this.groupBox2.Controls.Add(this.outputM3u);
            this.groupBox2.Location = new System.Drawing.Point(206, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 63);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Type";
            // 
            // outputMama
            // 
            this.outputMama.AutoSize = true;
            this.outputMama.Checked = true;
            this.outputMama.Location = new System.Drawing.Point(6, 24);
            this.outputMama.Name = "outputMama";
            this.outputMama.Size = new System.Drawing.Size(67, 21);
            this.outputMama.TabIndex = 7;
            this.outputMama.TabStop = true;
            this.outputMama.Text = "mama";
            this.outputMama.UseVisualStyleBackColor = true;
            this.outputMama.CheckedChanged += new System.EventHandler(this.outputMama_CheckedChanged);
            // 
            // outputM3u
            // 
            this.outputM3u.AutoSize = true;
            this.outputM3u.Location = new System.Drawing.Point(129, 24);
            this.outputM3u.Name = "outputM3u";
            this.outputM3u.Size = new System.Drawing.Size(56, 21);
            this.outputM3u.TabIndex = 8;
            this.outputM3u.Text = "m3u";
            this.outputM3u.UseVisualStyleBackColor = true;
            this.outputM3u.CheckedChanged += new System.EventHandler(this.outputM3u_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputChan);
            this.groupBox1.Controls.Add(this.inputM3u);
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 63);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Type";
            // 
            // inputChan
            // 
            this.inputChan.AutoSize = true;
            this.inputChan.Checked = true;
            this.inputChan.Location = new System.Drawing.Point(6, 24);
            this.inputChan.Name = "inputChan";
            this.inputChan.Size = new System.Drawing.Size(67, 21);
            this.inputChan.TabIndex = 7;
            this.inputChan.TabStop = true;
            this.inputChan.Text = "mama";
            this.inputChan.UseVisualStyleBackColor = true;
            this.inputChan.CheckedChanged += new System.EventHandler(this.inputMama_CheckedChanged);
            // 
            // inputM3u
            // 
            this.inputM3u.AutoSize = true;
            this.inputM3u.Location = new System.Drawing.Point(129, 24);
            this.inputM3u.Name = "inputM3u";
            this.inputM3u.Size = new System.Drawing.Size(56, 21);
            this.inputM3u.TabIndex = 8;
            this.inputM3u.Text = "m3u";
            this.inputM3u.UseVisualStyleBackColor = true;
            this.inputM3u.CheckedChanged += new System.EventHandler(this.inputM3u_CheckedChanged);
            // 
            // generateBtn
            // 
            this.generateBtn.Enabled = false;
            this.generateBtn.Location = new System.Drawing.Point(744, 54);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(172, 62);
            this.generateBtn.TabIndex = 6;
            this.generateBtn.Text = "Generate Channels";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output File Name:";
            // 
            // outputFileName
            // 
            this.outputFileName.Location = new System.Drawing.Point(566, 26);
            this.outputFileName.Name = "outputFileName";
            this.outputFileName.Size = new System.Drawing.Size(350, 22);
            this.outputFileName.TabIndex = 5;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(362, 25);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 3;
            this.browseBtn.Text = "Load";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File:";
            // 
            // dirName
            // 
            this.dirName.BackColor = System.Drawing.Color.White;
            this.dirName.Location = new System.Drawing.Point(46, 25);
            this.dirName.Name = "dirName";
            this.dirName.ReadOnly = true;
            this.dirName.Size = new System.Drawing.Size(310, 22);
            this.dirName.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearLog);
            this.tabPage2.Controls.Add(this.log);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(928, 751);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearLog
            // 
            this.clearLog.Location = new System.Drawing.Point(814, 712);
            this.clearLog.Name = "clearLog";
            this.clearLog.Size = new System.Drawing.Size(111, 33);
            this.clearLog.TabIndex = 1;
            this.clearLog.Text = "Clear";
            this.clearLog.UseVisualStyleBackColor = true;
            this.clearLog.Click += new System.EventHandler(this.clearLog_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.White;
            this.log.Dock = System.Windows.Forms.DockStyle.Top;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(3, 3);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(922, 703);
            this.log.TabIndex = 0;
            this.log.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.previewer);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(928, 751);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Channel Preview";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // previewer
            // 
            this.previewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewer.Enabled = true;
            this.previewer.Location = new System.Drawing.Point(0, 0);
            this.previewer.Name = "previewer";
            this.previewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("previewer.OcxState")));
            this.previewer.Size = new System.Drawing.Size(928, 751);
            this.previewer.TabIndex = 0;
            // 
            // ChannelsGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 780);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChannelsGenerator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Channels Generator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.settingsGbx.ResumeLayout(false);
            this.settingsGbx.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.previewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button clearLog;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.GroupBox settingsGbx;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton outputMama;
        private System.Windows.Forms.RadioButton outputM3u;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton inputChan;
        private System.Windows.Forms.RadioButton inputM3u;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputFileName;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dirName;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private AxAXVLC.AxVLCPlugin2 previewer;
        private AxAXVLC.AxVLCPlugin2 player;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
    }
}

