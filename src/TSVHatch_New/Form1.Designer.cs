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
        private System.Windows.Forms.TextBox txtStartFrame;
        private System.Windows.Forms.TextBox txtEndFrame;
        private System.Windows.Forms.TextBox txtSeed; // New seed input
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvFrames;
        private System.Windows.Forms.TextBox txtCurrentFrame;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnPlus100;
        private System.Windows.Forms.Button btnMinus100;
        private System.Windows.Forms.ComboBox cmbItemP1;
        private System.Windows.Forms.ComboBox cmbItemP2;

        private System.Windows.Forms.NumericUpDown[] p1IVs;
        private System.Windows.Forms.NumericUpDown[] p2IVs;

        private System.Windows.Forms.ComboBox cmbNatureP1;
        private System.Windows.Forms.ComboBox cmbNatureP2;

        private System.Windows.Forms.ComboBox cmbAbilityP1;
        private System.Windows.Forms.ComboBox cmbAbilityP2;
        private Control txtFrameStart;
        private Control txtFrameEnd;

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
            this.txtStartFrame = new System.Windows.Forms.TextBox();
            this.txtEndFrame = new System.Windows.Forms.TextBox();
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

            // ====== Start Frame Label ======
            Label lblStartFrame = new Label();
            lblStartFrame.Text = "Start Frame:";
            lblStartFrame.Location = new System.Drawing.Point(20, 50);
            lblStartFrame.AutoSize = true;
            this.Controls.Add(lblStartFrame);

            // ====== Start Frame TextBox ======
            this.txtStartFrame.Location = new System.Drawing.Point(20, 70);
            this.txtStartFrame.Size = new System.Drawing.Size(80, 20);

            // ====== End Frame Label ======
            Label lblEndFrame = new Label();
            lblEndFrame.Text = "End Frame:";
            lblEndFrame.Location = new System.Drawing.Point(120, 50);
            lblEndFrame.AutoSize = true;
            this.Controls.Add(lblEndFrame);

            // ====== End Frame TextBox ======
            this.txtEndFrame.Location = new System.Drawing.Point(120, 70);
            this.txtEndFrame.Size = new System.Drawing.Size(80, 20);

            // Search Button
            this.btnSearch.Location = new System.Drawing.Point(400, 60);
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
            this.btnAccept = new Button();
            this.btnAccept.Text = "Accept";
            this.btnAccept.Location = new System.Drawing.Point(780, 100);
            this.btnAccept.Size = new System.Drawing.Size(80, 30);
            this.btnAccept.Click += new EventHandler(this.btnAccept_Click);
            this.Controls.Add(this.btnAccept);

            // Reject Button
            this.btnReject = new Button();
            this.btnReject.Text = "Reject";
            this.btnReject.Location = new System.Drawing.Point(780, 140);
            this.btnReject.Size = new System.Drawing.Size(80, 30);
            this.btnReject.Click += new EventHandler(this.btnReject_Click);
            this.Controls.Add(this.btnReject);

            // +100 Frame Button
            this.btnPlus100 = new Button();
            this.btnPlus100.Text = "+100";
            this.btnPlus100.Location = new System.Drawing.Point(780, 180);
            this.btnPlus100.Size = new System.Drawing.Size(80, 30);
            this.btnPlus100.Click += new EventHandler(this.btnPlus100_Click);
            this.Controls.Add(this.btnPlus100);

            // -100 Frame Button
            this.btnMinus100 = new Button();
            this.btnMinus100.Text = "-100";
            this.btnMinus100.Location = new System.Drawing.Point(780, 220);
            this.btnMinus100.Size = new System.Drawing.Size(80, 30);
            this.btnMinus100.Click += new EventHandler(this.btnMinus100_Click);
            this.Controls.Add(this.btnMinus100);

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
                statLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular);  // Smaller font
                statLabel.Location = new System.Drawing.Point(200, 485 + i * 20);
                this.Controls.Add(statLabel);

                this.p1IVs[i] = new NumericUpDown();
                this.p1IVs[i].Minimum = 0;
                this.p1IVs[i].Maximum = 31;
                this.p1IVs[i].Size = new System.Drawing.Size(60, 20);  // Wider so values are visible
                this.p1IVs[i].Location = new System.Drawing.Point(100, 485 + i * 20);  // More gap from label
                this.Controls.Add(this.p1IVs[i]);
            }

            // ====== Parent 2 IVs ======

            Label lblP2 = new Label();
            lblP2.Text = "Parent 2 IVs:";
            lblP2.Location = new System.Drawing.Point(220, 460);
            this.Controls.Add(lblP2);

            this.p2IVs = new NumericUpDown[6];

            for (int i = 0; i < 6; i++)
            {
                Label statLabel = new Label();
                statLabel.Text = stats[i];
                statLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular);  // Smaller font
                statLabel.Location = new System.Drawing.Point(20, 485 + i * 20);
                this.Controls.Add(statLabel);

                this.p2IVs[i] = new NumericUpDown();
                this.p2IVs[i].Minimum = 0;
                this.p2IVs[i].Maximum = 31;
                this.p2IVs[i].Size = new System.Drawing.Size(60, 20);
                this.p2IVs[i].Location = new System.Drawing.Point(300, 485 + i * 20);
                this.Controls.Add(this.p2IVs[i]);
            }


            // ====== Nature and Ability ComboBoxes ======

            // Instantiate ComboBoxes
            this.cmbNatureP1 = new ComboBox();
            this.cmbNatureP2 = new ComboBox();
            this.cmbAbilityP1 = new ComboBox();
            this.cmbAbilityP2 = new ComboBox();

            // ====== Nature Labels ======

            Label lblNatureP1 = new Label();
            lblNatureP1.Text = "Nature P1:";
            lblNatureP1.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            lblNatureP1.Location = new System.Drawing.Point(0, 640);
            this.Controls.Add(lblNatureP1);

            Label lblNatureP2 = new Label();
            lblNatureP2.Text = "Nature P2:";
            lblNatureP2.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            lblNatureP2.Location = new System.Drawing.Point(200, 640);
            this.Controls.Add(lblNatureP2);

            // Nature ComboBoxes
            this.cmbNatureP1.Location = new System.Drawing.Point(100, 635);
            this.cmbNatureP2.Location = new System.Drawing.Point(300, 635);
            this.cmbNatureP1.Size = new System.Drawing.Size(100, 25);
            this.cmbNatureP2.Size = new System.Drawing.Size(100, 25);

            string[] natures = new string[] {
                "Hardy", "Lonely", "Brave", "Adamant", "Naughty",
                "Bold", "Docile", "Relaxed", "Impish", "Lax",
                "Timid", "Hasty", "Serious", "Jolly", "Naive",
                "Modest", "Mild", "Quiet", "Bashful", "Rash",
                "Calm", "Gentle", "Sassy", "Careful", "Quirky"
            };

            this.cmbNatureP1.Items.AddRange(natures);
            this.cmbNatureP2.Items.AddRange(natures);

            this.Controls.Add(this.cmbNatureP1);
            this.Controls.Add(this.cmbNatureP2);

            // ====== Ability Labels ======

            Label lblAbilityP1 = new Label();
            lblAbilityP1.Text = "Ability P1:";
            lblAbilityP1.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            lblAbilityP1.Location = new System.Drawing.Point(0, 670);
            this.Controls.Add(lblAbilityP1);

            Label lblAbilityP2 = new Label();
            lblAbilityP2.Text = "Ability P2:";
            lblAbilityP2.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            lblAbilityP2.Location = new System.Drawing.Point(200, 670);
            this.Controls.Add(lblAbilityP2);

            // Ability ComboBoxes
            this.cmbAbilityP1.Location = new System.Drawing.Point(100, 665);
            this.cmbAbilityP2.Location = new System.Drawing.Point(300, 665);
            this.cmbAbilityP1.Size = new System.Drawing.Size(100, 25);
            this.cmbAbilityP2.Size = new System.Drawing.Size(100, 25);

            string[] abilities = new string[] { "Ability 1", "Ability 2", "Hidden Ability" };

            this.cmbAbilityP1.Items.AddRange(abilities);
            this.cmbAbilityP2.Items.AddRange(abilities);

            this.Controls.Add(this.cmbAbilityP1);
            this.Controls.Add(this.cmbAbilityP2);

            // ====== Item Dropdowns ======

            // Item P1 ComboBox
            this.cmbItemP1 = new ComboBox();
            this.cmbItemP1.Location = new System.Drawing.Point(100, 730);
            this.cmbItemP1.Size = new System.Drawing.Size(140, 25);
            this.cmbItemP1.Items.AddRange(new string[] { "None", "Everstone", "Destiny Knot" });
            this.cmbItemP1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(this.cmbItemP1);

            // Item P2 ComboBox
            this.cmbItemP2 = new ComboBox();
            this.cmbItemP2.Location = new System.Drawing.Point(300, 730);
            this.cmbItemP2.Size = new System.Drawing.Size(140, 25);
            this.cmbItemP2.Items.AddRange(new string[] { "None", "Everstone", "Destiny Knot" });
            this.cmbItemP2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Controls.Add(this.cmbItemP2);

            // ====== Item P1 Label ======
            Label lblItemP1 = new Label();
            lblItemP1.Text = "Item P1:";
            lblItemP1.Location = new System.Drawing.Point(20, 750);
            lblItemP1.AutoSize = true;
            this.Controls.Add(lblItemP1);

            // ====== Item P1 ComboBox ======
            this.cmbItemP1.Location = new System.Drawing.Point(20, 770);
            this.cmbItemP1.Size = new System.Drawing.Size(140, 25);

            // ====== Item P2 Label ======
            Label lblItemP2 = new Label();
            lblItemP2.Text = "Item P2:";
            lblItemP2.Location = new System.Drawing.Point(180, 750);
            lblItemP2.AutoSize = true;
            this.Controls.Add(lblItemP2);

            // ====== Item P2 ComboBox ======
            this.cmbItemP2.Location = new System.Drawing.Point(180, 770);
            this.cmbItemP2.Size = new System.Drawing.Size(140, 25);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(900, 800);
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
