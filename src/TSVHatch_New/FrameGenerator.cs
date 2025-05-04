
using System;
using System.Collections.Generic;

namespace TSV_Hatch
{
    public class FrameData
    {
        public int FrameNumber { get; set; }
        public int Frame { get; set; }
        public bool IsTSVShiny { get; set; }
        public int ESV { get; set; }
        public bool IsShiny { get; set; }
        public string Gender { get; set; }
        public string Ability { get; set; }
        public string HPType { get; set; }
        public string PID { get; set; }
        public int[] IVs { get; set; }
        public string Nature { get; set; }
    }

    public class FrameGenerator
    {
        private int TSV;
        private bool ShinyCharm;
        private bool MasudaMethod;
        private uint? SeedOverride;
        private int[] P1IVs;
        private int[] P2IVs;
        private bool DestinyKnot;
        private bool EverstoneP1;
        private bool EverstoneP2;
        private string NatureP1;
        private string NatureP2;

        public FrameGenerator(
            int tsv,
            bool shinyCharm,
            bool masudaMethod,
            uint? seed,
            int[] parent1IVs,
            int[] parent2IVs,
            bool destinyKnot,
            bool everstoneP1,
            bool everstoneP2,
            string natureP1,
            string natureP2)
        {
            TSV = tsv;
            ShinyCharm = shinyCharm;
            MasudaMethod = masudaMethod;
            SeedOverride = seed;
            P1IVs = parent1IVs;
            P2IVs = parent2IVs;
            DestinyKnot = destinyKnot;
            EverstoneP1 = everstoneP1;
            EverstoneP2 = everstoneP2;
            NatureP1 = natureP1;
            NatureP2 = natureP2;
        }

        public List<FrameData> GenerateFrames(int startFrame, int endFrame)
        {
            List<FrameData> frames = new List<FrameData>();

            for (int frame = startFrame; frame <= endFrame; frame++)
            {
                FrameData data = new FrameData();
                data.Frame = frame;

                int rngSeed = SeedOverride.HasValue ? (int)(SeedOverride.Value + frame) : frame;
                Random rng = new Random(rngSeed); // Deterministic per frame

                string pid = rng.Next(0, int.MaxValue).ToString("X8");
                data.PID = pid;

                int esv = CalculateESV(pid);
                data.ESV = esv;
                data.IsTSVShiny = (esv == TSV);

                data.Gender = (rng.NextDouble() > 0.5) ? "Male" : "Female";
                data.Ability = (rng.NextDouble() > 0.5) ? "Ability 1" : "Ability 2";
                data.HPType = "Dark"; // Placeholder

                // 1. Determine inherited IVs
                int[] childIVs = new int[6];
                Array.Fill(childIVs, -1); // -1 means not inherited yet

                List<int> stats = new List<int> { 0, 1, 2, 3, 4, 5 };
                int numInherited = DestinyKnot ? 5 : 3;

                // Choose stats to inherit
                for (int i = 0; i < numInherited; i++)
                {
                    int index = rng.Next(stats.Count);
                    int stat = stats[index];
                    stats.RemoveAt(index);

                    // Randomly pick parent
                    if (rng.NextDouble() < 0.5)
                        childIVs[stat] = P1IVs[stat];
                    else
                        childIVs[stat] = P2IVs[stat];
                }

                // Fill remaining stats randomly
                for (int i = 0; i < 6; i++)
                {
                    if (childIVs[i] == -1)
                        childIVs[i] = rng.Next(32);
                }

                data.IVs = childIVs;

                // 2. Determine nature
                if (EverstoneP1 && EverstoneP2)
                {
                    data.Nature = rng.NextDouble() < 0.5 ? NatureP1 : NatureP2;
                }
                else if (EverstoneP1)
                {
                    data.Nature = NatureP1;
                }
                else if (EverstoneP2)
                {
                    data.Nature = NatureP2;
                }
                else
                {
                    // Random nature
                    string[] allNatures = new string[] {
                    "Hardy", "Lonely", "Brave", "Adamant", "Naughty",
                    "Bold", "Docile", "Relaxed", "Impish", "Lax",
                    "Timid", "Hasty", "Serious", "Jolly", "Naive",
                    "Modest", "Mild", "Quiet", "Bashful", "Rash",
                    "Calm", "Gentle", "Sassy", "Careful", "Quirky"
                };
                    data.Nature = allNatures[rng.Next(allNatures.Length)];
                }

                frames.Add(data);
            }

            return frames;
        }

        private int CalculateESV(string pid)
        {
            int high = Convert.ToInt32(pid.Substring(0, 4), 16);
            int low = Convert.ToInt32(pid.Substring(4, 4), 16);
            return (high ^ low) >> 4;
        }
    }
}
