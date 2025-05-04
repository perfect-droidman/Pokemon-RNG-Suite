using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms; // ⬅ this line is likely missing!

namespace TSV_Hatch
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtTSV;
        private System.Windows.Forms.CheckBox chkShinyCharm;
        private System.Windows.Forms.CheckBox chkMasuda;
        private System.Windows.Forms.TextBox txtFrameStart;
        private System.Windows.Forms.TextBox txtFrameEnd;
        private System.Windows.Forms.TextBox txtSeed; // New seed input
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvFrames;
        private System.Windows.Forms.TextBox txtCurrentFrame;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnPlus100;
        private System.Windows.Forms.Button btnMinus100;
        private System.Windows.Forms.CheckBox chkDestinyKnot;
        private System.Windows.Forms.CheckBox chkEverstoneP1;
        private System.Windows.Forms.CheckBox chkEverstoneP2;

        private System.Windows.Forms.NumericUpDown[] p1IVs;
        private System.Windows.Forms.NumericUpDown[] p2IVs;

        private System.Windows.Forms.ComboBox cmbNatureP1;
        private System.Windows.Forms.ComboBox cmbNatureP2;

        private System.Windows.Forms.ComboBox cmbAbilityP1;
        private System.Windows.Forms.ComboBox cmbAbilityP2;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTSV = new System.Windows.Forms.TextBox();
            this.chkShinyCharm = new System.Windows.Forms.CheckBox();
            this.chkMasuda = new System.Windows.Forms.CheckBox();
            this.txtFrameStart = new System.Windows.Forms.TextBox();
            this.txtFrameEnd = new System.Windows.Forms.TextBox();
            this.txtSeed = new System.Windows.Forms.TextBox(); // Seed
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvFrames = new System.Windows.Forms.DataGridView();
            this.txtCurrentFrame = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnPlus100 = new System.Windows.Forms.Button();
            this.btnMinus100 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrames)).BeginInit();
            this.SuspendLayout();

            // TSV Input
            this.txtTSV.Location = new System.Drawing.Point(20, 20);
            this.txtTSV.Size = new System.Drawing.Size(100, 20);
            this.txtTSV.PlaceholderText = "TSV";

            // Shiny Charm Checkbox
            this.chkShinyCharm.Location = new System.Drawing.Point(140, 20);
            this.chkShinyCharm.Text = "Shiny Charm";

            // Masuda Checkbox
            this.chkMasuda.Location = new System.Drawing.Point(260, 20);
            this.chkMasuda.Text = "Masuda Method";

            // Seed Input
            this.txtSeed.Location = new System.Drawing.Point(380, 20);
            this.txtSeed.Size = new System.Drawing.Size(150, 20);
            this.txtSeed.PlaceholderText = "Seed (optional)";

            // Frame Start
            this.txtFrameStart.Location = new System.Drawing.Point(20, 60);
            this.txtFrameStart.Size = new System.Drawing.Size(100, 20);
            this.txtFrameStart.PlaceholderText = "Start Frame";

            // Frame End
            this.txtFrameEnd.Location = new System.Drawing.Point(140, 60);
            this.txtFrameEnd.Size = new System.Drawing.Size(100, 20);
            this.txtFrameEnd.PlaceholderText = "End Frame";

            // Search Button
            this.btnSearch.Location = new System.Drawing.Point(260, 60);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // Data Grid View for Frames
            this.dgvFrames.Location = new System.Drawing.Point(20, 100);
            this.dgvFrames.Size = new System.Drawing.Size(740, 300);
            this.dgvFrames.ColumnCount = 7;
            this.dgvFrames.Columns[0].Name = "Frame";
            this.dgvFrames.Columns[1].Name = "ESV";
            this.dgvFrames.Columns[2].Name = "Shiny?";
            this.dgvFrames.Columns[3].Name = "Gender";
            this.dgvFrames.Columns[4].Name = "Ability";
            this.dgvFrames.Columns[5].Name = "HP Type";
            this.dgvFrames.Columns[6].Name = "PID";

            // Current Frame display
            this.txtCurrentFrame.Location = new System.Drawing.Point(20, 370);
            this.txtCurrentFrame.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentFrame.Text = "0";

            // Accept Button
            this.btnAccept.Location = new System.Drawing.Point(140, 370);
            this.btnAccept.Text = "Accept";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);

            // Reject Button
            this.btnReject.Location = new System.Drawing.Point(240, 370);
            this.btnReject.Text = "Reject";
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);

            // Plus 100 Frame Button
            this.btnPlus100.Location = new System.Drawing.Point(340, 370);
            this.btnPlus100.Text = "+100";
            this.btnPlus100.Click += new System.EventHandler(this.btnPlus100_Click);

            // Minus 100 Frame Button
            this.btnMinus100.Location = new System.Drawing.Point(440, 370);
            this.btnMinus100.Text = "-100";
            this.btnMinus100.Click += new System.EventHandler(this.btnMinus100_Click);

            // Destiny Knot and Everstones
            this.chkDestinyKnot = new System.Windows.Forms.CheckBox();
            this.chkDestinyKnot.Text = "Destiny Knot";
            this.chkDestinyKnot.Location = new System.Drawing.Point(600, 20);
            this.Controls.Add(this.chkDestinyKnot);

            this.chkEverstoneP1 = new System.Windows.Forms.CheckBox();
            this.chkEverstoneP1.Text = "Everstone P1";
            this.chkEverstoneP1.Location = new System.Drawing.Point(600, 50);
            this.Controls.Add(this.chkEverstoneP1);

            this.chkEverstoneP2 = new System.Windows.Forms.CheckBox();
            this.chkEverstoneP2.Text = "Everstone P2";
            this.chkEverstoneP2.Location = new System.Drawing.Point(700, 50);
            this.Controls.Add(this.chkEverstoneP2);

            // ====== Parent 1 IVs ======

            Label lblP1 = new Label();
            lblP1.Text = "Parent 1 IVs:";
            lblP1.Location = new System.Drawing.Point(20, 460);
            this.Controls.Add(lblP1);

            string[] stats = { "HP", "Atk", "Def", "SpA", "SpD", "Spe" };

            this.p1IVs = new NumericUpDown[6];

            for (int i = 0; i < 6; i++)
            {
                Label statLabel = new Label();
                statLabel.Text = stats[i];
                statLabel.Location = new System.Drawing.Point(20, 485 + i * 25);
                this.Controls.Add(statLabel);

                this.p1IVs[i] = new NumericUpDown();
                this.p1IVs[i].Minimum = 0;
                this.p1IVs[i].Maximum = 31;
                this.p1IVs[i].Size = new System.Drawing.Size(40, 20); // Narrow width
                this.p1IVs[i].Location = new System.Drawing.Point(70, 485 + i * 25);
                this.Controls.Add(this.p1IVs[i]);
            }

            // ====== Parent 2 IVs ======

            Label lblP2 = new Label();
            lblP2.Text = "Parent 2 IVs:";
            lblP2.Location = new System.Drawing.Point(200, 460);
            this.Controls.Add(lblP2);

            this.p2IVs = new NumericUpDown[6];

            for (int i = 0; i < 6; i++)
            {
                Label statLabel = new Label();
                statLabel.Text = stats[i];
                statLabel.Location = new System.Drawing.Point(200, 485 + i * 25);
                this.Controls.Add(statLabel);

                this.p2IVs[i] = new NumericUpDown();
                this.p2IVs[i].Minimum = 0;
                this.p2IVs[i].Maximum = 31;
                this.p2IVs[i].Size = new System.Drawing.Size(40, 20);
                this.p2IVs[i].Location = new System.Drawing.Point(250, 485 + i * 25);
                this.Controls.Add(this.p2IVs[i]);
            }

            // ====== Nature and Ability ComboBoxes ======

            // Instantiate the ComboBoxes
            this.cmbNatureP1 = new ComboBox();
            this.cmbNatureP2 = new ComboBox();
            this.cmbAbilityP1 = new ComboBox();
            this.cmbAbilityP2 = new ComboBox();

            // Nature Labels
            Label lblNatureP1 = new Label();
            lblNatureP1.Text = "Nature P1:";
            lblNatureP1.Location = new System.Drawing.Point(20, 640);
            this.Controls.Add(lblNatureP1);

            Label lblNatureP2 = new Label();
            lblNatureP2.Text = "Nature P2:";
            lblNatureP2.Location = new System.Drawing.Point(200, 640);
            this.Controls.Add(lblNatureP2);

            // Nature ComboBoxes
            this.cmbNatureP1.Location = new System.Drawing.Point(90, 635);
            this.cmbNatureP2.Location = new System.Drawing.Point(270, 635);

            string[] natures = new string[] {
                "Hardy", "Lonely", "Brave", "Adamant", "Naughty",
                "Bold", "Docile", "Relaxed", "Impish", "Lax",
                "Timid", "Hasty", "Serious", "Jolly", "Naive",
                "Modest", "Mild", "Quiet", "Bashful", "Rash",
                "Calm", "Gentle", "Sassy", "Careful", "Quirky"
            };

            this.cmbNatureP1.Items.AddRange(natures);
            this.cmbNatureP2.Items.AddRange(natures);

            // Add Nature ComboBoxes to form
            this.Controls.Add(this.cmbNatureP1);
            this.Controls.Add(this.cmbNatureP2);

            // Ability Labels
            Label lblAbilityP1 = new Label();
            lblAbilityP1.Text = "Ability P1:";
            lblAbilityP1.Location = new System.Drawing.Point(20, 670);
            this.Controls.Add(lblAbilityP1);

            Label lblAbilityP2 = new Label();
            lblAbilityP2.Text = "Ability P2:";
            lblAbilityP2.Location = new System.Drawing.Point(200, 670);
            this.Controls.Add(lblAbilityP2);

            // Ability ComboBoxes
            this.cmbAbilityP1.Location = new System.Drawing.Point(90, 665);
            this.cmbAbilityP2.Location = new System.Drawing.Point(270, 665);

            string[] abilities = new string[] { "Ability 1", "Ability 2", "Hidden Ability" };

            this.cmbAbilityP1.Items.AddRange(abilities);
            this.cmbAbilityP2.Items.AddRange(abilities);

            // Add Ability ComboBoxes to form
            this.Controls.Add(this.cmbAbilityP1);
            this.Controls.Add(this.cmbAbilityP2);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.txtTSV);
            this.Controls.Add(this.chkShinyCharm);
            this.Controls.Add(this.chkMasuda);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.txtFrameStart);
            this.Controls.Add(this.txtFrameEnd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvFrames);
            this.Controls.Add(this.txtCurrentFrame);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnPlus100);
            this.Controls.Add(this.btnMinus100);
            this.Text = "Pokémon RNG Suite — TSV Hatch Simulator";

            ((System.ComponentModel.ISupportInitialize)(this.dgvFrames)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
