namespace PEOReplayAnalyser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Replay? ourReplay;
        private void ToolstripFileLoadReplay_Click(object sender, EventArgs e)
        {
            FileDialogLoadReplay.Filter = "Replay file (*.myreplay)|*.myreplay|JSON file (*.json)|*.json|All files (*.*)|*.*";
            var result = FileDialogLoadReplay.ShowDialog();

            if (result == DialogResult.OK) 
            {
                Stream stream = FileDialogLoadReplay.OpenFile() as Stream;
                string output = "";

                while (stream.Position < stream.Length) 
                {
                    output += (char) stream.ReadByte();
                }

                ourReplay = Parser.Parse(output);

                if (ourReplay != null) 
                {
                    LabelJudgeSick.Text = "Sicks\n"  + ourReplay.Sicks;
                    LabelJudgeGood.Text = "Goods\n"  + ourReplay.Goods;
                    LabelJudgeBad.Text  = "Bads\n"   + ourReplay.Bads;
                    LabelJudgeShit.Text = "Shits\n"  + ourReplay.Shits;
                    LabelJudgeMiss.Text = "Misses\n" + ourReplay.Misses;

                    LabelJudgePA.Text = "PA\n" + (ourReplay.Goods == 0 ? "Infinity" : (ourReplay.Sicks / ourReplay.Goods).ToString("N2"));

                    int hits = 0;
                    hits += ourReplay.Sicks + ourReplay.Goods + ourReplay.Bads + ourReplay.Shits;

                    LabelJudgeHitRatio.Text = "Hit Ratio\n" + (ourReplay.Misses == 0 ? "Infinity" : (hits / ourReplay.Misses).ToString("N2"));

                }
            }
        }
    }
}
