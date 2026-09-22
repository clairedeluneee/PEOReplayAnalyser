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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            ToolstripFileLoadReplay = new ToolStripMenuItem();
            FileDialogLoadReplay = new OpenFileDialog();
            groupBox1 = new GroupBox();
            LabelJudgeHitRatio = new Label();
            LabelJudgePA = new Label();
            LabelJudgeMiss = new Label();
            LabelJudgeShit = new Label();
            LabelJudgeBad = new Label();
            LabelJudgeGood = new Label();
            LabelJudgeSick = new Label();
            groupBox2 = new GroupBox();
            LabelKeyUps = new Label();
            LabelKeyDowns = new Label();
            groupBox3 = new GroupBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolstripFileLoadReplay });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // ToolstripFileLoadReplay
            // 
            ToolstripFileLoadReplay.Name = "ToolstripFileLoadReplay";
            ToolstripFileLoadReplay.Size = new Size(135, 22);
            ToolstripFileLoadReplay.Text = "Load replay";
            ToolstripFileLoadReplay.Click += ToolstripFileLoadReplay_Click;
            // 
            // FileDialogLoadReplay
            // 
            FileDialogLoadReplay.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LabelJudgeHitRatio);
            groupBox1.Controls.Add(LabelJudgePA);
            groupBox1.Controls.Add(LabelJudgeMiss);
            groupBox1.Controls.Add(LabelJudgeShit);
            groupBox1.Controls.Add(LabelJudgeBad);
            groupBox1.Controls.Add(LabelJudgeGood);
            groupBox1.Controls.Add(LabelJudgeSick);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 119);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Judgements";
            // 
            // LabelJudgeHitRatio
            // 
            LabelJudgeHitRatio.Location = new Point(95, 63);
            LabelJudgeHitRatio.Name = "LabelJudgeHitRatio";
            LabelJudgeHitRatio.Size = new Size(83, 32);
            LabelJudgeHitRatio.TabIndex = 5;
            LabelJudgeHitRatio.Text = "Hit Ratio";
            LabelJudgeHitRatio.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgePA
            // 
            LabelJudgePA.Location = new Point(6, 63);
            LabelJudgePA.Name = "LabelJudgePA";
            LabelJudgePA.Size = new Size(83, 32);
            LabelJudgePA.TabIndex = 4;
            LabelJudgePA.Text = "PA";
            LabelJudgePA.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgeMiss
            // 
            LabelJudgeMiss.Location = new Point(362, 19);
            LabelJudgeMiss.Name = "LabelJudgeMiss";
            LabelJudgeMiss.Size = new Size(83, 32);
            LabelJudgeMiss.TabIndex = 2;
            LabelJudgeMiss.Text = "Misses";
            LabelJudgeMiss.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgeShit
            // 
            LabelJudgeShit.Location = new Point(273, 19);
            LabelJudgeShit.Name = "LabelJudgeShit";
            LabelJudgeShit.Size = new Size(83, 32);
            LabelJudgeShit.TabIndex = 3;
            LabelJudgeShit.Text = "Shits";
            LabelJudgeShit.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgeBad
            // 
            LabelJudgeBad.Location = new Point(184, 19);
            LabelJudgeBad.Name = "LabelJudgeBad";
            LabelJudgeBad.Size = new Size(83, 32);
            LabelJudgeBad.TabIndex = 2;
            LabelJudgeBad.Text = "Bads";
            LabelJudgeBad.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgeGood
            // 
            LabelJudgeGood.Location = new Point(95, 19);
            LabelJudgeGood.Name = "LabelJudgeGood";
            LabelJudgeGood.Size = new Size(83, 32);
            LabelJudgeGood.TabIndex = 1;
            LabelJudgeGood.Text = "Goods";
            LabelJudgeGood.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelJudgeSick
            // 
            LabelJudgeSick.Location = new Point(6, 19);
            LabelJudgeSick.Name = "LabelJudgeSick";
            LabelJudgeSick.Size = new Size(83, 32);
            LabelJudgeSick.TabIndex = 0;
            LabelJudgeSick.Text = "Sicks";
            LabelJudgeSick.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LabelKeyUps);
            groupBox2.Controls.Add(LabelKeyDowns);
            groupBox2.Location = new Point(12, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 128);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inputs";
            // 
            // LabelKeyUps
            // 
            LabelKeyUps.Location = new Point(6, 62);
            LabelKeyUps.Name = "LabelKeyUps";
            LabelKeyUps.Size = new Size(83, 32);
            LabelKeyUps.TabIndex = 7;
            LabelKeyUps.Text = "Keys Released";
            LabelKeyUps.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelKeyDowns
            // 
            LabelKeyDowns.Location = new Point(6, 19);
            LabelKeyDowns.Name = "LabelKeyDowns";
            LabelKeyDowns.Size = new Size(83, 32);
            LabelKeyDowns.TabIndex = 6;
            LabelKeyDowns.Text = "Keys Pressed";
            LabelKeyDowns.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(492, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(296, 119);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Song Info";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
    }
}
