using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace PEOReplayAnalyser
{
    public class Replay 
    {
        public string SongID = String.Empty;
        public int Version;
        public Modifiers? Gameplay_Modifiers;

        public object[]? Inputs;

        public int Sicks;
        public int Goods;
        public int Bads;
        public int Shits;
        public int Misses;

        public string Song = String.Empty;
        public string Difficulty = String.Empty;
        public long Beat_Time = 0;

        public double Safe_Frames = 10.0;
        public double Rating_Offset = 0.0;
        public double Note_Offset = 0.0;

        public string? Mod_Url = null;
        public int Keys = 4;

        public int Points;
        public double Accuracy;
        public int Score;
        public bool OpponentMode;
        public string Player = String.Empty;

        public string Chart_Hash = String.Empty;
    }

    public class Modifiers 
    {
        public bool Instakill;
        public bool OpponentPlay;
        public bool ScrollSpeedByMania;
        public double SongSpeed;
        public string Mania = String.Empty;
        public double HealthGain;
        public bool Practice;
        public bool Botplay;
        public bool NoBadNotes;
        public double HealthLoss;
        public string ScrollType = "Constant";
        public string ScrollType_4K = "Constant";
    }
    public class Parser
    {

        static readonly JsonSerializerOptions options = new()
        {
            PropertyNameCaseInsensitive = true,
            AllowOutOfOrderMetadataProperties = true,
            AllowTrailingCommas = true,
            IncludeFields = true,

        };
        public static Replay? Parse(string str) 
        {

            try 
            {
                var ser = JsonSerializer.Deserialize<Replay>(str, options);
                return ser;
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }


}
