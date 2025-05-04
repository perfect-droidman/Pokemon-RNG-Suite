
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
            string seedInput = txtSeed.Text;

            uint? seed = null;
            if (!string.IsNullOrWhiteSpace(seedInput))
            {
                if (uint.TryParse(seedInput, System.Globalization.NumberStyles.HexNumber, null, out uint parsedSeed))
                {
                    seed = parsedSeed;
                }
                else
                {
                    MessageBox.Show("Invalid seed. Please enter a valid hexadecimal seed.");
                    return;
                }
            }

            // Collect parent IVs from the NumericUpDown controls
            int[] parent1IVs = new int[6];
            int[] parent2IVs = new int[6];

            for (int i = 0; i < 6; i++)
            {
                parent1IVs[i] = (int)p1IVs[i].Value;
                parent2IVs[i] = (int)p2IVs[i].Value;
            }

            // Collect breeding items and natures
            bool destinyKnot = chkDestinyKnot.Checked;
            bool everstoneP1 = chkEverstoneP1.Checked;
            bool everstoneP2 = chkEverstoneP2.Checked;
            string natureP1 = cmbNatureP1.SelectedItem?.ToString() ?? "Hardy";
            string natureP2 = cmbNatureP2.SelectedItem?.ToString() ?? "Hardy";

            frameGen = new FrameGenerator(
                tsv,
                shinyCharm,
                masuda,
                seed,
                parent1IVs,
                parent2IVs,
                destinyKnot,
                everstoneP1,
                everstoneP2,
                natureP1,
                natureP2);

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
            // Stay on the same frame
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
