
using System;
using System.Collections.Generic;

namespace TSV_Hatch
{
    public class FrameData
    {
        public int Frame { get; set; }
        public int ESV { get; set; }
        public bool IsTSVShiny { get; set; }
        public string Gender { get; set; }
        public int Ability { get; set; }
        public string HPType { get; set; }
        public string PID { get; set; }
    }

    public class FrameGenerator
    {
        private int TSV;
        private bool ShinyCharm;
        private bool MasudaMethod;

        public FrameGenerator(int tsv, bool shinyCharm, bool masudaMethod)
        {
            TSV = tsv;
            ShinyCharm = shinyCharm;
            MasudaMethod = masudaMethod;
        }

        public List<FrameData> GenerateFrames(int startFrame, int endFrame)
        {
            List<FrameData> frames = new List<FrameData>();

            for (int frame = startFrame; frame <= endFrame; frame++)
            {
                FrameData data = new FrameData();
                data.Frame = frame;

                Random rng = new Random(frame); // Frame as seed for deterministic results
                string pid = rng.Next(0, int.MaxValue).ToString("X8");
                data.PID = pid;

                int esv = CalculateESV(pid);
                data.ESV = esv;
                data.IsTSVShiny = (esv == TSV);

                data.Gender = (rng.NextDouble() > 0.5) ? "Male" : "Female";
                data.Ability = (rng.NextDouble() > 0.5) ? 1 : 2;
                data.HPType = "Dark"; // Placeholder

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
