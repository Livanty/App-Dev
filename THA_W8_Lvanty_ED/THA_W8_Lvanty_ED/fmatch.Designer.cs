namespace THA_W8_Lvanty_ED
{
    partial class fmatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_match = new System.Windows.Forms.ComboBox();
            this.cmb_team = new System.Windows.Forms.ComboBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(25, 109);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(418, 314);
            this.dgv1.TabIndex = 9;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose Match:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Team:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_match
            // 
            this.cmb_match.FormattingEnabled = true;
            this.cmb_match.Location = new System.Drawing.Point(148, 60);
            this.cmb_match.Name = "cmb_match";
            this.cmb_match.Size = new System.Drawing.Size(136, 28);
            this.cmb_match.TabIndex = 6;
            this.cmb_match.SelectedIndexChanged += new System.EventHandler(this.cmb_match_SelectedIndexChanged);
            // 
            // cmb_team
            // 
            this.cmb_team.FormattingEnabled = true;
            this.cmb_team.Location = new System.Drawing.Point(148, 19);
            this.cmb_team.Name = "cmb_team";
            this.cmb_team.Size = new System.Drawing.Size(136, 28);
            this.cmb_team.TabIndex = 5;
            this.cmb_team.SelectedIndexChanged += new System.EventHandler(this.cmb_team_SelectedIndexChanged);
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(462, 109);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 62;
            this.dgv2.RowTemplate.Height = 28;
            this.dgv2.Size = new System.Drawing.Size(426, 314);
            this.dgv2.TabIndex = 10;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // fmatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 500);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_match);
            this.Controls.Add(this.cmb_team);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmatch";
            this.Text = "fmatch";
            this.Load += new System.EventHandler(this.fmatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_match;
        private System.Windows.Forms.ComboBox cmb_team;
        private System.Windows.Forms.DataGridView dgv2;
    }
}