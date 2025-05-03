
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TSV_Hatch
{
    public partial class Form1 : Form
    {
        private FrameGenerator frameGen;
        private int currentFrame;

        public Form1()
        {
            InitializeComponent();
            frameGen = null;
            currentFrame = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int tsv = int.Parse(txtTSV.Text);
            bool shinyCharm = chkShinyCharm.Checked;
            bool masuda = chkMasuda.Checked;
            int startFrame = int.Parse(txtFrameStart.Text);
            int endFrame = int.Parse(txtFrameEnd.Text);

            frameGen = new FrameGenerator(tsv, shinyCharm, masuda);

            List<FrameData> results = frameGen.GenerateFrames(startFrame, endFrame);
            PopulateFrameViewer(results);
        }

        private void PopulateFrameViewer(List<FrameData> frames)
        {
            dgvFrames.Rows.Clear();

            foreach (var frame in frames)
            {
                dgvFrames.Rows.Add(
                    frame.Frame,
                    frame.ESV,
                    frame.IsTSVShiny ? "TSV!" : "No",
                    frame.Gender,
                    frame.Ability,
                    frame.HPType,
                    frame.PID
                );
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            currentFrame++;
            txtCurrentFrame.Text = currentFrame.ToString();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            // Do nothing — stay on same frame
        }

        private void btnPlus100_Click(object sender, EventArgs e)
        {
            currentFrame += 100;
            txtCurrentFrame.Text = currentFrame.ToString();
        }

        private void btnMinus100_Click(object sender, EventArgs e)
        {
            currentFrame -= 100;
            txtCurrentFrame.Text = currentFrame.ToString();
        }
    }
}
