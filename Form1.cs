using System.Diagnostics;
using System.Text.Json;

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
            FileDialogLoadReplay.Filter = "Replay file (*.funkinreplay)|*.funkinreplay|JSON file (*.json)|*.json|All files (*.*)|*.*";
            var result = FileDialogLoadReplay.ShowDialog();

            if (result == DialogResult.OK)
            {
                string output = String.Empty;

                try
                {
                    output = File.ReadAllText(FileDialogLoadReplay.FileName);
                }
                catch
                {

                }


                ourReplay = Parser.Parse(output.Replace("\r\n", "").Trim());

                ToolstripFileViewLeaderboard.Enabled = ourReplay != null;

                if (ourReplay != null)
                {
                    ToolstripFileDownloadMod.Enabled = ourReplay.Mod_Url != null && ourReplay.Mod_Url != String.Empty;

                    LabelJudgeSick.Text = "Sicks\n" + ourReplay.Sicks;
                    LabelJudgeGood.Text = "Goods\n" + ourReplay.Goods;
                    LabelJudgeBad.Text = "Bads\n" + ourReplay.Bads;
                    LabelJudgeShit.Text = "Shits\n" + ourReplay.Shits;
                    LabelJudgeMiss.Text = "Misses\n" + ourReplay.Misses;

                    int pure = 0;
                    pure += ourReplay.Sicks * 350;
                    pure += ourReplay.Goods * 200;
                    pure += ourReplay.Bads * 100;
                    pure += ourReplay.Shits * 50;
                    pure -= ourReplay.Misses * 10;

                    LabelPureScore.Text = "Pure Score\n" + pure;

                    LabelJudgePA.Text = "PA\n" + (ourReplay.Goods == 0 ? "Infinity" : (ourReplay.Sicks / ourReplay.Goods).ToString("N2"));

                    int hits = 0;
                    hits += ourReplay.Sicks + ourReplay.Goods + ourReplay.Bads + ourReplay.Shits;

                    double notesHit = 0.0;
                    notesHit += ourReplay.Sicks;
                    notesHit += ourReplay.Goods * 0.67;
                    notesHit += ourReplay.Bads * 0.34;

                    LabelAccuracy.Text = "Accuracy\n" + (hits == 0 ? "100.00%" : (notesHit / (hits + ourReplay.Misses)).ToString("P2"));

                    LabelHits.Text = "Hits\n" + hits;
                    LabelJudgeHitRatio.Text = "Hit Ratio\n" + (ourReplay.Misses == 0 ? "Infinity" : (hits / ourReplay.Misses).ToString("N2"));

                    int keyDowns = 0;
                    int keyUps = 0;
                    if (ourReplay.Inputs != null)
                    {
                        foreach (JsonElement input in ourReplay.Inputs.Select(v => (JsonElement)v))
                        {
                            if (input[2].ToString() == "1") keyDowns++;
                            else if (input[2].ToString() == "0") keyUps++;
                        }
                    }

                    LabelGhostTaps.Text = "Ghost Taps\n" + (keyDowns - hits);
                    LabelKeyDowns.Text = "Keys Pressed\n" + keyDowns;
                    LabelKeyUps.Text = "Keys Released\n" + keyUps;

                    Dictionary<string, string> info = new Dictionary<string, string>();

                    LabelInfoLHS.Text = String.Empty;
                    LabelInfoRHS.Text = String.Empty;

                    info.Add("Played by", ourReplay.Player);
                    info.Add("Played at", DateTime.UnixEpoch.AddMilliseconds(ourReplay.Beat_Time).ToString("yyyy-MM-dd HH:mm:ss"));
                    info.Add("null1", String.Empty);
                    info.Add("Song", ourReplay.Song);
                    info.Add("Difficulty", ourReplay.Difficulty);
                    info.Add("null2", String.Empty);
                    info.Add("Score", ourReplay.Score.ToString());
                    info.Add("Accuracy", (ourReplay.Accuracy).ToString("N2") + "%");
                    info.Add("Points", ourReplay.Points.ToString());
                    info.Add("Side", ourReplay.OpponentMode ? "Dad" : "Boyfriend");


                    foreach (KeyValuePair<string, string> pair in info)
                    {
                        if (pair.Value == String.Empty)
                        {
                            LabelInfoLHS.Text += "\n";
                            LabelInfoRHS.Text += "\n";
                            continue;
                        }

                        LabelInfoLHS.Text += pair.Key + "\n";
                        LabelInfoRHS.Text += pair.Value + "\n";
                    }
                }
            }
        }

        private static void OpenURL(string url)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch
            {
            }
        }

        private void ToolstripFileViewLeaderboard_Click(object sender, EventArgs e)
        {
            if (ourReplay == null) return;
            string theId = ourReplay.SongID;
            if (theId == String.Empty) theId = $"{ourReplay.Song.Replace(" ", "")}-{ourReplay.Difficulty.Replace(" ", "")}-{ourReplay.Chart_Hash}";
            OpenURL($"https://funkin.sniro.boo/song/{theId}?strum={(ourReplay.OpponentMode ? 1 : 2)}");
        }

        private void ToolstripFileDownloadMod_Click(object sender, EventArgs e)
        {
            if (ourReplay == null) return;
            if (ourReplay.Mod_Url == null || ourReplay.Mod_Url == String.Empty) return;
            OpenURL(ourReplay.Mod_Url);
        }
    }
}
