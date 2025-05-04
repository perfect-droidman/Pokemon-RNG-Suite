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

            // Parent 1 IVs
            this.p1IVs = new System.Windows.Forms.NumericUpDown[6];
            string[] stats = { "HP", "Atk", "Def", "SpA", "SpD", "Spe" };

            Label lblP1 = new Label();
            lblP1.Text = "Parent 1 IVs:";
            lblP1.Location = new System.Drawing.Point(20, 460);
            this.Controls.Add(lblP1);

            for (int i = 0; i < 6; i++)
            {
                this.p1IVs[i] = new System.Windows.Forms.NumericUpDown();
                this.p1IVs[i].Minimum = 0;
                this.p1IVs[i].Maximum = 31;
                this.p1IVs[i].Location = new System.Drawing.Point(100 + i * 60, 400);
                this.Controls.Add(this.p1IVs[i]);
            }

            // Parent 2 IVs
            this.p2IVs = new System.Windows.Forms.NumericUpDown[6];

            Label lblP2 = new Label();
            lblP2.Text = "Parent 2 IVs:";
            lblP2.Location = new System.Drawing.Point(20, 500);
            this.Controls.Add(lblP2);

            for (int i = 0; i < 6; i++)
            {
                this.p2IVs[i] = new System.Windows.Forms.NumericUpDown();
                this.p2IVs[i].Minimum = 0;
                this.p2IVs[i].Maximum = 31;
                this.p2IVs[i].Location = new System.Drawing.Point(100 + i * 60, 430);
                this.Controls.Add(this.p2IVs[i]);
            }

            // Parent 1 Nature
            this.cmbNatureP1 = new System.Windows.Forms.ComboBox();
            this.cmbNatureP1.Location = new System.Drawing.Point(20, 540);
            this.cmbNatureP1.Items.AddRange(new string[] {
                "Hardy", "Lonely", "Brave", "Adamant", "Naughty",
                "Bold", "Docile", "Relaxed", "Impish", "Lax",
                "Timid", "Hasty", "Serious", "Jolly", "Naive",
                "Modest", "Mild", "Quiet", "Bashful", "Rash",
                "Calm", "Gentle", "Sassy", "Careful", "Quirky"
            });
            this.Controls.Add(this.cmbNatureP1);

            // Parent 2 Nature
            this.cmbNatureP2 = new System.Windows.Forms.ComboBox();
            this.cmbNatureP2.Location = new System.Drawing.Point(180, 540);
            object[] natureArray = new object[this.cmbNatureP1.Items.Count];
            this.cmbNatureP1.Items.CopyTo(natureArray, 0);
            this.cmbNatureP2.Items.AddRange(natureArray);
            this.Controls.Add(this.cmbNatureP2);

            // Parent 1 Ability
            this.cmbAbilityP1 = new System.Windows.Forms.ComboBox();
            this.cmbAbilityP1.Location = new System.Drawing.Point(20, 580);
            this.cmbAbilityP1.Items.AddRange(new string[] { "Ability 1", "Ability 2", "Hidden Ability" });
            this.Controls.Add(this.cmbAbilityP1);

            // Parent 2 Ability
            this.cmbAbilityP2 = new System.Windows.Forms.ComboBox();
            this.cmbAbilityP2.Location = new System.Drawing.Point(180, 580);
            this.cmbAbilityP2.Items.AddRange(new string[] { "Ability 1", "Ability 2", "Hidden Ability" });
            this.Controls.Add(this.cmbAbilityP2);


            // Form Settings
            this.ClientSize = new System.Drawing.Size(900, 600);
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
