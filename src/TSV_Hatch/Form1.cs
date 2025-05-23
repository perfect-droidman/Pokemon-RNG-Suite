
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
            // Parse TSV
            if (!int.TryParse(txtTSV.Text, out int tsv))
            {
                MessageBox.Show("Invalid TSV.");
                return;
            }

            bool shinyCharm = chkShinyCharm.Checked;
            bool masuda = chkMasuda.Checked;

            uint? seed = null;
            if (!string.IsNullOrWhiteSpace(txtSeed.Text))
            {
                if (!uint.TryParse(txtSeed.Text, System.Globalization.NumberStyles.HexNumber, null, out uint parsedSeed))
                {
                    MessageBox.Show("Invalid Seed.");
                    return;
                }
                seed = parsedSeed;
            }

            // Start/End Frames
            if (!int.TryParse(txtStartFrame.Text, out int startFrame))
            {
                MessageBox.Show("Invalid start frame.");
                return;
            }

            if (!int.TryParse(txtEndFrame.Text, out int endFrame))
            {
                MessageBox.Show("Invalid end frame.");
                return;
            }

            // Collect Parent IVs
            int[] parent1IVs = new int[6];
            int[] parent2IVs = new int[6];

            for (int i = 0; i < 6; i++)
            {
                parent1IVs[i] = (int)p1IVs[i].Value;
                parent2IVs[i] = (int)p2IVs[i].Value;
            }

            // Nature & Ability
            string natureP1 = cmbNatureP1.SelectedItem?.ToString() ?? "Hardy";
            string natureP2 = cmbNatureP2.SelectedItem?.ToString() ?? "Hardy";

            string abilityP1 = cmbAbilityP1.SelectedItem?.ToString() ?? "Ability 1";
            string abilityP2 = cmbAbilityP2.SelectedItem?.ToString() ?? "Ability 1";

            // Item Effects - Destiny Knot & Everstones
            bool destinyKnot = false;
            bool everstoneP1 = false;
            bool everstoneP2 = false;

            string itemP1 = cmbItemP1.SelectedItem?.ToString() ?? "None";
            string itemP2 = cmbItemP2.SelectedItem?.ToString() ?? "None";

            if (itemP1 == "Destiny Knot" || itemP2 == "Destiny Knot")
                destinyKnot = true;

            if (itemP1 == "Everstone")
                everstoneP1 = true;

            if (itemP2 == "Everstone")
                everstoneP2 = true;

            // Instantiate FrameGenerator
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
                natureP2
            );

            // Clear previous results
            dgvFrames.Rows.Clear();

            // Generate frames and display results
            var results = frameGen.GenerateFrames(startFrame, endFrame);

            foreach (var frame in results)
            {
                dgvFrames.Rows.Add(
                    frame.FrameNumber,
                    frame.ESV,
                    frame.IsShiny ? "Yes" : "No",
                    frame.Gender,
                    frame.Ability,
                    frame.HPType,
                    frame.PID
                );
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // TODO: Implement frame accept logic
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            // TODO: Implement frame reject logic
        }

        private void btnPlus100_Click(object sender, EventArgs e)
        {
            // TODO: Implement +100 frame shift
        }

        private void btnMinus100_Click(object sender, EventArgs e)
        {
            // TODO: Implement -100 frame shift
        }
    }
}