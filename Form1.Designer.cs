namespace PEOReplayAnalyser
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            ToolstripFileLoadReplay = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolstripFileViewLeaderboard = new ToolStripMenuItem();
            ToolstripFileDownloadMod = new ToolStripMenuItem();
            FileDialogLoadReplay = new OpenFileDialog();
            groupBox1 = new GroupBox();
            LabelAccuracy = new Label();
            LabelPureScore = new Label();
            LabelHits = new Label();
            LabelJudgeHitRatio = new Label();
            LabelJudgePA = new Label();
            LabelJudgeMiss = new Label();
            LabelJudgeShit = new Label();
            LabelJudgeBad = new Label();
            LabelJudgeGood = new Label();
            LabelJudgeSick = new Label();
            groupBox2 = new GroupBox();
            LabelGhostTaps = new Label();
            LabelKeyUps = new Label();
            LabelKeyDowns = new Label();
            groupBox3 = new GroupBox();
            LabelInfoRHS = new Label();
            LabelInfoLHS = new Label();
            TooltipThing = new ToolTip(components);
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(914, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolstripFileLoadReplay, toolStripSeparator1, ToolstripFileViewLeaderboard, ToolstripFileDownloadMod });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(41, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // ToolstripFileLoadReplay
            // 
            ToolstripFileLoadReplay.Name = "ToolstripFileLoadReplay";
            ToolstripFileLoadReplay.Size = new Size(187, 22);
            ToolstripFileLoadReplay.Text = "Load replay";
            ToolstripFileLoadReplay.Click += ToolstripFileLoadReplay_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(184, 6);
            // 
            // ToolstripFileViewLeaderboard
            // 
            ToolstripFileViewLeaderboard.Enabled = false;
            ToolstripFileViewLeaderboard.Name = "ToolstripFileViewLeaderboard";
            ToolstripFileViewLeaderboard.Size = new Size(187, 22);
            ToolstripFileViewLeaderboard.Text = "View leaderboard";
            ToolstripFileViewLeaderboard.Click += ToolstripFileViewLeaderboard_Click;
            // 
            // ToolstripFileDownloadMod
            // 
            ToolstripFileDownloadMod.Enabled = false;
            ToolstripFileDownloadMod.Name = "ToolstripFileDownloadMod";
            ToolstripFileDownloadMod.Size = new Size(187, 22);
            ToolstripFileDownloadMod.Text = "Download mod";
            ToolstripFileDownloadMod.Click += ToolstripFileDownloadMod_Click;
            // 
            // FileDialogLoadReplay
            // 
            FileDialogLoadReplay.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LabelAccuracy);
            groupBox1.Controls.Add(LabelPureScore);
            groupBox1.Controls.Add(LabelHits);
            groupBox1.Controls.Add(LabelJudgeHitRatio);
            groupBox1.Controls.Add(LabelJudgePA);
            groupBox1.Controls.Add(LabelJudgeMiss);
            groupBox1.Controls.Add(LabelJudgeShit);
            groupBox1.Controls.Add(LabelJudgeBad);
            groupBox1.Controls.Add(LabelJudgeGood);
            groupBox1.Controls.Add(LabelJudgeSick);
            groupBox1.Location = new Point(14, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 119);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Judgements";
            // 
            // LabelAccuracy
            // 
            LabelAccuracy.Location = new Point(312, 63);
            LabelAccuracy.Name = "LabelAccuracy";
            LabelAccuracy.Size = new Size(95, 32);
            LabelAccuracy.TabIndex = 8;
            LabelAccuracy.Text = "Accuracy";
            LabelAccuracy.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelPureScore
            // 
            LabelPureScore.Location = new Point(210, 63);
            LabelPureScore.Name = "LabelPureScore";
            LabelPureScore.Size = new Size(95, 32);
            LabelPureScore.TabIndex = 7;
            LabelPureScore.Text = "Pure Score";
            LabelPureScore.TextAlign = ContentAlignment.TopCenter;
            TooltipThing.SetToolTip(LabelPureScore, "The score you would have gotten if there was no combo bonus given.\r\nUsed during online play.");
            // 
            // LabelHits
            // 
            LabelHits.Location = new Point(414, 63);
            LabelHits.Name = "LabelHits";
            LabelHits.Size = new Size(95, 32);
            LabelHits.TabIndex = 6;
            LabelHits.Text = "Hits";
            LabelHits.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgeHitRatio
            // 
            LabelJudgeHitRatio.Location = new Point(109, 63);
            LabelJudgeHitRatio.Name = "LabelJudgeHitRatio";
            LabelJudgeHitRatio.Size = new Size(95, 32);
            LabelJudgeHitRatio.TabIndex = 5;
            LabelJudgeHitRatio.Text = "Hit Ratio";
            LabelJudgeHitRatio.TextAlign = ContentAlignment.TopCenter;
            TooltipThing.SetToolTip(LabelJudgeHitRatio, "The ratio of all hits and misses. \r\nIf this shows \"Infinity\", then there aren't any misses to begin with.");
            // 
            // LabelJudgePA
            // 
            LabelJudgePA.Location = new Point(7, 63);
            LabelJudgePA.Name = "LabelJudgePA";
            LabelJudgePA.Size = new Size(95, 32);
            LabelJudgePA.TabIndex = 4;
            LabelJudgePA.Text = "PA";
            LabelJudgePA.TextAlign = ContentAlignment.TopCenter;
            TooltipThing.SetToolTip(LabelJudgePA, "Perfect Accuracy.\r\nThis is the ratio of sicks to goods. Lower means tighter hits.\r\nIf this shows \"Infinity\", then there aren't any goods to begin with.");
            // 
            // LabelJudgeMiss
            // 
            LabelJudgeMiss.Location = new Point(414, 19);
            LabelJudgeMiss.Name = "LabelJudgeMiss";
            LabelJudgeMiss.Size = new Size(95, 32);
            LabelJudgeMiss.TabIndex = 2;
            LabelJudgeMiss.Text = "Misses";
            LabelJudgeMiss.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgeShit
            // 
            LabelJudgeShit.Location = new Point(312, 19);
            LabelJudgeShit.Name = "LabelJudgeShit";
            LabelJudgeShit.Size = new Size(95, 32);
            LabelJudgeShit.TabIndex = 3;
            LabelJudgeShit.Text = "Shits";
            LabelJudgeShit.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgeBad
            // 
            LabelJudgeBad.Location = new Point(210, 19);
            LabelJudgeBad.Name = "LabelJudgeBad";
            LabelJudgeBad.Size = new Size(95, 32);
            LabelJudgeBad.TabIndex = 2;
            LabelJudgeBad.Text = "Bads";
            LabelJudgeBad.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgeGood
            // 
            LabelJudgeGood.Location = new Point(109, 19);
            LabelJudgeGood.Name = "LabelJudgeGood";
            LabelJudgeGood.Size = new Size(95, 32);
            LabelJudgeGood.TabIndex = 1;
            LabelJudgeGood.Text = "Goods";
            LabelJudgeGood.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgeSick
            // 
            LabelJudgeSick.Location = new Point(7, 19);
            LabelJudgeSick.Name = "LabelJudgeSick";
            LabelJudgeSick.Size = new Size(95, 32);
            LabelJudgeSick.TabIndex = 0;
            LabelJudgeSick.Text = "Sicks";
            LabelJudgeSick.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LabelGhostTaps);
            groupBox2.Controls.Add(LabelKeyUps);
            groupBox2.Controls.Add(LabelKeyDowns);
            groupBox2.Location = new Point(14, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 128);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inputs";
            // 
            // LabelGhostTaps
            // 
            LabelGhostTaps.Location = new Point(109, 19);
            LabelGhostTaps.Name = "LabelGhostTaps";
            LabelGhostTaps.Size = new Size(95, 32);
            LabelGhostTaps.TabIndex = 8;
            LabelGhostTaps.Text = "Ghost Taps";
            LabelGhostTaps.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelKeyUps
            // 
            LabelKeyUps.Location = new Point(7, 62);
            LabelKeyUps.Name = "LabelKeyUps";
            LabelKeyUps.Size = new Size(95, 32);
            LabelKeyUps.TabIndex = 7;
            LabelKeyUps.Text = "Keys Released";
            LabelKeyUps.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelKeyDowns
            // 
            LabelKeyDowns.Location = new Point(7, 19);
            LabelKeyDowns.Name = "LabelKeyDowns";
            LabelKeyDowns.Size = new Size(95, 32);
            LabelKeyDowns.TabIndex = 6;
            LabelKeyDowns.Text = "Keys Pressed";
            LabelKeyDowns.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LabelInfoRHS);
            groupBox3.Controls.Add(LabelInfoLHS);
            groupBox3.Location = new Point(562, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(338, 253);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Replay Info";
            // 
            // LabelInfoRHS
            // 
            LabelInfoRHS.Location = new Point(115, 19);
            LabelInfoRHS.Name = "LabelInfoRHS";
            LabelInfoRHS.Size = new Size(217, 231);
            LabelInfoRHS.TabIndex = 1;
            LabelInfoRHS.Text = "Played by";
            LabelInfoRHS.TextAlign = ContentAlignment.TopRight;
            // 
            // LabelInfoLHS
            // 
            LabelInfoLHS.Location = new Point(6, 19);
            LabelInfoLHS.Name = "LabelInfoLHS";
            LabelInfoLHS.Size = new Size(170, 231);
            LabelInfoLHS.TabIndex = 0;
            LabelInfoLHS.Text = "Played by";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Psych Engine Online Replay Analyzer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ToolstripFileLoadReplay;
        private OpenFileDialog FileDialogLoadReplay;
        private GroupBox groupBox1;
        private Label LabelJudgeMiss;
        private Label LabelJudgeShit;
        private Label LabelJudgeBad;
        private Label LabelJudgeGood;
        private Label LabelJudgeSick;
        private Label LabelJudgeHitRatio;
        private Label LabelJudgePA;
        private GroupBox groupBox2;
        private Label LabelKeyDowns;
        private Label LabelKeyUps;
        private GroupBox groupBox3;
        private Label LabelHits;
        private Label LabelGhostTaps;
        private Label LabelInfoRHS;
        private Label LabelInfoLHS;
        private Label LabelPureScore;
        private Label LabelAccuracy;
        private ToolTip TooltipThing;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ToolstripFileViewLeaderboard;
        private ToolStripMenuItem ToolstripFileDownloadMod;
    }
}
