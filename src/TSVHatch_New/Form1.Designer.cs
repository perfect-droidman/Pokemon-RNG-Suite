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
            txtTSV = new TextBox();
            chkShinyCharm = new CheckBox();
            chkMasuda = new CheckBox();
            txtStartFrame = new TextBox();
            txtEndFrame = new TextBox();
            txtSeed = new TextBox();
            btnSearch = new Button();
            dgvFrames = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            txtCurrentFrame = new TextBox();
            btnAccept = new Button();
            btnReject = new Button();
            btnPlus100 = new Button();
            btnMinus100 = new Button();
            lblStartFrame = new Label();
            lblEndFrame = new Label();
            lblP1 = new Label();
            lblP2 = new Label();
            cmbNatureP1 = new ComboBox();
            cmbNatureP2 = new ComboBox();
            cmbAbilityP1 = new ComboBox();
            cmbAbilityP2 = new ComboBox();
            lblNatureP1 = new Label();
            lblNatureP2 = new Label();
            lblAbilityP1 = new Label();
            lblAbilityP2 = new Label();
            cmbItemP1 = new ComboBox();
            cmbItemP2 = new ComboBox();
            lblItemP1 = new Label();
            lblItemP2 = new Label();
            ((ISupportInitialize)dgvFrames).BeginInit();
            SuspendLayout();
            // 
            // txtTSV
            // 
            txtTSV.Location = new Point(20, 20);
            txtTSV.Name = "txtTSV";
            txtTSV.PlaceholderText = "TSV";
            txtTSV.Size = new Size(100, 23);
            txtTSV.TabIndex = 22;
            // 
            // chkShinyCharm
            // 
            chkShinyCharm.Location = new Point(140, 20);
            chkShinyCharm.Name = "chkShinyCharm";
            chkShinyCharm.Size = new Size(104, 24);
            chkShinyCharm.TabIndex = 23;
            chkShinyCharm.Text = "Shiny Charm";
            // 
            // chkMasuda
            // 
            chkMasuda.Location = new Point(260, 20);
            chkMasuda.Name = "chkMasuda";
            chkMasuda.Size = new Size(104, 24);
            chkMasuda.TabIndex = 24;
            chkMasuda.Text = "Masuda Method";
            // 
            // txtStartFrame
            // 
            txtStartFrame.Location = new Point(20, 70);
            txtStartFrame.Name = "txtStartFrame";
            txtStartFrame.Size = new Size(80, 23);
            txtStartFrame.TabIndex = 1;
            // 
            // txtEndFrame
            // 
            txtEndFrame.Location = new Point(120, 70);
            txtEndFrame.Name = "txtEndFrame";
            txtEndFrame.Size = new Size(80, 23);
            txtEndFrame.TabIndex = 3;
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(380, 20);
            txtSeed.Name = "txtSeed";
            txtSeed.PlaceholderText = "Seed (optional)";
            txtSeed.Size = new Size(150, 23);
            txtSeed.TabIndex = 25;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(400, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 26;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvFrames
            // 
            dgvFrames.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dgvFrames.Location = new Point(20, 100);
            dgvFrames.Name = "dgvFrames";
            dgvFrames.Size = new Size(740, 300);
            dgvFrames.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // txtCurrentFrame
            // 
            txtCurrentFrame.Location = new Point(20, 370);
            txtCurrentFrame.Name = "txtCurrentFrame";
            txtCurrentFrame.Size = new Size(100, 23);
            txtCurrentFrame.TabIndex = 28;
            txtCurrentFrame.Text = "0";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(780, 100);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(80, 30);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Accept";
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(780, 140);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(80, 30);
            btnReject.TabIndex = 5;
            btnReject.Text = "Reject";
            btnReject.Click += btnReject_Click;
            // 
            // btnPlus100
            // 
            btnPlus100.Location = new Point(780, 180);
            btnPlus100.Name = "btnPlus100";
            btnPlus100.Size = new Size(80, 30);
            btnPlus100.TabIndex = 6;
            btnPlus100.Text = "+100";
            btnPlus100.Click += btnPlus100_Click;
            // 
            // btnMinus100
            // 
            btnMinus100.Location = new Point(780, 220);
            btnMinus100.Name = "btnMinus100";
            btnMinus100.Size = new Size(80, 30);
            btnMinus100.TabIndex = 7;
            btnMinus100.Text = "-100";
            btnMinus100.Click += btnMinus100_Click;
            // 
            // lblStartFrame
            // 
            lblStartFrame.AutoSize = true;
            lblStartFrame.Location = new Point(20, 50);
            lblStartFrame.Name = "lblStartFrame";
            lblStartFrame.Size = new Size(70, 15);
            lblStartFrame.TabIndex = 0;
            lblStartFrame.Text = "Start Frame:";
            // 
            // lblEndFrame
            // 
            lblEndFrame.AutoSize = true;
            lblEndFrame.Location = new Point(120, 50);
            lblEndFrame.Name = "lblEndFrame";
            lblEndFrame.Size = new Size(66, 15);
            lblEndFrame.TabIndex = 2;
            lblEndFrame.Text = "End Frame:";
            // 
            // lblP1
            // 
            lblP1.Location = new Point(20, 460);
            lblP1.Name = "lblP1";
            lblP1.Size = new Size(100, 23);
            lblP1.TabIndex = 8;
            lblP1.Text = "Parent 1 IVs:";
            // 
            // lblP2
            // 
            lblP2.Location = new Point(220, 460);
            lblP2.Name = "lblP2";
            lblP2.Size = new Size(100, 23);
            lblP2.TabIndex = 9;
            lblP2.Text = "Parent 2 IVs:";
            // 
            // cmbNatureP1
            // 
            cmbNatureP1.Items.AddRange(new object[] { "Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky" });
            cmbNatureP1.Location = new Point(76, 636);
            cmbNatureP1.Name = "cmbNatureP1";
            cmbNatureP1.Size = new Size(100, 23);
            cmbNatureP1.TabIndex = 12;
            // 
            // cmbNatureP2
            // 
            cmbNatureP2.Items.AddRange(new object[] { "Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky" });
            cmbNatureP2.Location = new Point(270, 636);
            cmbNatureP2.Name = "cmbNatureP2";
            cmbNatureP2.Size = new Size(100, 23);
            cmbNatureP2.TabIndex = 13;
            // 
            // cmbAbilityP1
            // 
            cmbAbilityP1.Items.AddRange(new object[] { "Ability 1", "Ability 2", "Hidden Ability" });
            cmbAbilityP1.Location = new Point(76, 670);
            cmbAbilityP1.Name = "cmbAbilityP1";
            cmbAbilityP1.Size = new Size(100, 23);
            cmbAbilityP1.TabIndex = 16;
            // 
            // cmbAbilityP2
            // 
            cmbAbilityP2.Items.AddRange(new object[] { "Ability 1", "Ability 2", "Hidden Ability" });
            cmbAbilityP2.Location = new Point(270, 665);
            cmbAbilityP2.Name = "cmbAbilityP2";
            cmbAbilityP2.Size = new Size(100, 23);
            cmbAbilityP2.TabIndex = 17;
            // 
            // lblNatureP1
            // 
            lblNatureP1.Font = new Font("Segoe UI", 8F);
            lblNatureP1.Location = new Point(0, 640);
            lblNatureP1.Name = "lblNatureP1";
            lblNatureP1.Size = new Size(70, 23);
            lblNatureP1.TabIndex = 10;
            lblNatureP1.Text = "Nature P1:";
            // 
            // lblNatureP2
            // 
            lblNatureP2.Font = new Font("Segoe UI", 8F);
            lblNatureP2.Location = new Point(200, 640);
            lblNatureP2.Name = "lblNatureP2";
            lblNatureP2.Size = new Size(64, 23);
            lblNatureP2.TabIndex = 11;
            lblNatureP2.Text = "Nature P2:";
            // 
            // lblAbilityP1
            // 
            lblAbilityP1.Font = new Font("Segoe UI", 8F);
            lblAbilityP1.Location = new Point(0, 670);
            lblAbilityP1.Name = "lblAbilityP1";
            lblAbilityP1.Size = new Size(70, 23);
            lblAbilityP1.TabIndex = 14;
            lblAbilityP1.Text = "Ability P1:";
            // 
            // lblAbilityP2
            // 
            lblAbilityP2.Font = new Font("Segoe UI", 8F);
            lblAbilityP2.Location = new Point(200, 670);
            lblAbilityP2.Name = "lblAbilityP2";
            lblAbilityP2.Size = new Size(64, 23);
            lblAbilityP2.TabIndex = 15;
            lblAbilityP2.Text = "Ability P2:";
            // 
            // cmbItemP1
            // 
            cmbItemP1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItemP1.Items.AddRange(new object[] { "None", "Everstone", "Destiny Knot" });
            cmbItemP1.Location = new Point(12, 727);
            cmbItemP1.Name = "cmbItemP1";
            cmbItemP1.Size = new Size(140, 23);
            cmbItemP1.TabIndex = 18;
            // 
            // cmbItemP2
            // 
            cmbItemP2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItemP2.Items.AddRange(new object[] { "None", "Everstone", "Destiny Knot" });
            cmbItemP2.Location = new Point(180, 727);
            cmbItemP2.Name = "cmbItemP2";
            cmbItemP2.Size = new Size(140, 23);
            cmbItemP2.TabIndex = 19;
            // 
            // lblItemP1
            // 
            lblItemP1.AutoSize = true;
            lblItemP1.Location = new Point(0, 709);
            lblItemP1.Name = "lblItemP1";
            lblItemP1.Size = new Size(50, 15);
            lblItemP1.TabIndex = 20;
            lblItemP1.Text = "Item P1:";
            // 
            // lblItemP2
            // 
            lblItemP2.AutoSize = true;
            lblItemP2.Location = new Point(180, 709);
            lblItemP2.Name = "lblItemP2";
            lblItemP2.Size = new Size(50, 15);
            lblItemP2.TabIndex = 21;
            lblItemP2.Text = "Item P2:";
            // 
            // Form1
            // 
            ClientSize = new Size(900, 800);
            Controls.Add(lblStartFrame);
            Controls.Add(txtStartFrame);
            Controls.Add(lblEndFrame);
            Controls.Add(txtEndFrame);
            Controls.Add(lblP1);
            Controls.Add(lblP2);
            Controls.Add(lblNatureP1);
            Controls.Add(lblNatureP2);
            Controls.Add(cmbNatureP1);
            Controls.Add(cmbNatureP2);
            Controls.Add(lblAbilityP1);
            Controls.Add(lblAbilityP2);
            Controls.Add(cmbAbilityP1);
            Controls.Add(cmbAbilityP2);
            Controls.Add(cmbItemP1);
            Controls.Add(cmbItemP2);
            Controls.Add(lblItemP1);
            Controls.Add(lblItemP2);
            Controls.Add(txtTSV);
            Controls.Add(chkShinyCharm);
            Controls.Add(chkMasuda);
            Controls.Add(txtSeed);
            Controls.Add(btnSearch);
            Controls.Add(dgvFrames);
            Controls.Add(txtCurrentFrame);
            Controls.Add(btnAccept);
            Controls.Add(btnReject);
            Controls.Add(btnPlus100);
            Controls.Add(btnMinus100);
            Name = "Form1";
            Text = "Pokémon RNG Suite — TSV Hatch Simulator";
            Load += Form1_Load;
            ((ISupportInitialize)dgvFrames).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Label lblStartFrame;
        private Label lblEndFrame;
        private Label lblP1;
        private Label lblP2;
        private Label lblNatureP1;
        private Label lblNatureP2;
        private Label lblAbilityP1;
        private Label lblAbilityP2;
        private Label lblItemP1;
        private Label lblItemP2;
    }
}
