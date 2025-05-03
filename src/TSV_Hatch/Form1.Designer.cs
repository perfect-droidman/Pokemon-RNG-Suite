
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvFrames;
        private System.Windows.Forms.TextBox txtCurrentFrame;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnPlus100;
        private System.Windows.Forms.Button btnMinus100;

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
            this.dgvFrames.Size = new System.Drawing.Size(740, 250);
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

            // Form Settings
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.txtTSV);
            this.Controls.Add(this.chkShinyCharm);
            this.Controls.Add(this.chkMasuda);
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
