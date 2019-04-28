namespace TetrisApp
{
    partial class TetrisForm
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
            this.panelTeris = new TetrisApp.MyPanel();
            this.panelNextBrick = new TetrisApp.MyPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreNum = new System.Windows.Forms.Label();
            this.grpBxDifficulties = new System.Windows.Forms.GroupBox();
            this.radBtnHard = new System.Windows.Forms.RadioButton();
            this.radBtnMedian = new System.Windows.Forms.RadioButton();
            this.radBtnEasy = new System.Windows.Forms.RadioButton();
            this.tmTick = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3.SuspendLayout();
            this.grpBxDifficulties.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTeris
            // 
            this.panelTeris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTeris.Location = new System.Drawing.Point(42, 27);
            this.panelTeris.Name = "panelTeris";
            this.panelTeris.Size = new System.Drawing.Size(300, 400);
            this.panelTeris.TabIndex = 0;
            this.panelTeris.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTeris_Paint);
            // 
            // panelNextBrick
            // 
            this.panelNextBrick.Location = new System.Drawing.Point(481, 27);
            this.panelNextBrick.Name = "panelNextBrick";
            this.panelNextBrick.Size = new System.Drawing.Size(80, 80);
            this.panelNextBrick.TabIndex = 5;
            this.panelNextBrick.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelNextBrick_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnResume);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnPause);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Location = new System.Drawing.Point(393, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 137);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "S: Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "D: Go right";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "A: Go Left";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "W: Rotate";
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(23, 73);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 23);
            this.btnResume.TabIndex = 3;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(23, 102);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(23, 44);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(413, 262);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreNum
            // 
            this.lblScoreNum.AutoSize = true;
            this.lblScoreNum.Location = new System.Drawing.Point(478, 262);
            this.lblScoreNum.Name = "lblScoreNum";
            this.lblScoreNum.Size = new System.Drawing.Size(13, 13);
            this.lblScoreNum.TabIndex = 4;
            this.lblScoreNum.Text = "0";
            // 
            // grpBxDifficulties
            // 
            this.grpBxDifficulties.Controls.Add(this.radBtnHard);
            this.grpBxDifficulties.Controls.Add(this.radBtnMedian);
            this.grpBxDifficulties.Controls.Add(this.radBtnEasy);
            this.grpBxDifficulties.Location = new System.Drawing.Point(393, 151);
            this.grpBxDifficulties.Name = "grpBxDifficulties";
            this.grpBxDifficulties.Size = new System.Drawing.Size(200, 98);
            this.grpBxDifficulties.TabIndex = 4;
            this.grpBxDifficulties.TabStop = false;
            this.grpBxDifficulties.Text = "Difficulties";
            // 
            // radBtnHard
            // 
            this.radBtnHard.AutoSize = true;
            this.radBtnHard.Location = new System.Drawing.Point(23, 68);
            this.radBtnHard.Name = "radBtnHard";
            this.radBtnHard.Size = new System.Drawing.Size(48, 17);
            this.radBtnHard.TabIndex = 2;
            this.radBtnHard.TabStop = true;
            this.radBtnHard.Text = "Hard";
            this.radBtnHard.UseVisualStyleBackColor = true;
            // 
            // radBtnMedian
            // 
            this.radBtnMedian.AutoSize = true;
            this.radBtnMedian.Location = new System.Drawing.Point(23, 44);
            this.radBtnMedian.Name = "radBtnMedian";
            this.radBtnMedian.Size = new System.Drawing.Size(60, 17);
            this.radBtnMedian.TabIndex = 1;
            this.radBtnMedian.TabStop = true;
            this.radBtnMedian.Text = "Median";
            this.radBtnMedian.UseVisualStyleBackColor = true;
            // 
            // radBtnEasy
            // 
            this.radBtnEasy.AutoSize = true;
            this.radBtnEasy.Location = new System.Drawing.Point(23, 20);
            this.radBtnEasy.Name = "radBtnEasy";
            this.radBtnEasy.Size = new System.Drawing.Size(48, 17);
            this.radBtnEasy.TabIndex = 0;
            this.radBtnEasy.TabStop = true;
            this.radBtnEasy.Text = "Easy";
            this.radBtnEasy.UseVisualStyleBackColor = true;
            this.radBtnEasy.CheckedChanged += new System.EventHandler(this.RadBtn_CheckedChanged);
            // 
            // tmTick
            // 
            this.tmTick.Tick += new System.EventHandler(this.TmTick_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Next Brick:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // TetrisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(642, 462);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelNextBrick);
            this.Controls.Add(this.lblScoreNum);
            this.Controls.Add(this.grpBxDifficulties);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTeris);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TetrisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.TerisForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TerisForm_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpBxDifficulties.ResumeLayout(false);
            this.grpBxDifficulties.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblScoreNum;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpBxDifficulties;
        private System.Windows.Forms.RadioButton radBtnHard;
        private System.Windows.Forms.RadioButton radBtnMedian;
        private System.Windows.Forms.RadioButton radBtnEasy;
        private System.Windows.Forms.Timer tmTick;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MyPanel panelTeris;
        private MyPanel panelNextBrick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

