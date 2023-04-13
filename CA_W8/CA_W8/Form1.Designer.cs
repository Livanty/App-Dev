namespace CA_W8
{
    partial class Form1
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
            this.dgv_pemain = new System.Windows.Forms.DataGridView();
            this.LabelValue = new System.Windows.Forms.Label();
            this.Label_Value = new System.Windows.Forms.Label();
            this.combo_Nationality = new System.Windows.Forms.ComboBox();
            this.cmb_namaclub = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pemain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_pemain
            // 
            this.dgv_pemain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pemain.Location = new System.Drawing.Point(13, 82);
            this.dgv_pemain.Name = "dgv_pemain";
            this.dgv_pemain.Size = new System.Drawing.Size(775, 356);
            this.dgv_pemain.TabIndex = 0;
            // 
            // LabelValue
            // 
            this.LabelValue.AutoSize = true;
            this.LabelValue.Location = new System.Drawing.Point(38, 34);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(66, 13);
            this.LabelValue.TabIndex = 1;
            this.LabelValue.Text = "Label Value:";
            // 
            // Label_Value
            // 
            this.Label_Value.AutoSize = true;
            this.Label_Value.Location = new System.Drawing.Point(114, 34);
            this.Label_Value.Name = "Label_Value";
            this.Label_Value.Size = new System.Drawing.Size(35, 13);
            this.Label_Value.TabIndex = 2;
            this.Label_Value.Text = "label2";
            // 
            // combo_Nationality
            // 
            this.combo_Nationality.FormattingEnabled = true;
            this.combo_Nationality.Location = new System.Drawing.Point(41, 13);
            this.combo_Nationality.Name = "combo_Nationality";
            this.combo_Nationality.Size = new System.Drawing.Size(121, 21);
            this.combo_Nationality.TabIndex = 3;
            this.combo_Nationality.SelectedIndexChanged += new System.EventHandler(this.combo_Nationality_SelectedIndexChanged);
            // 
            // cmb_namaclub
            // 
            this.cmb_namaclub.FormattingEnabled = true;
            this.cmb_namaclub.Location = new System.Drawing.Point(642, 12);
            this.cmb_namaclub.Name = "cmb_namaclub";
            this.cmb_namaclub.Size = new System.Drawing.Size(121, 21);
            this.cmb_namaclub.TabIndex = 4;
            this.cmb_namaclub.SelectedIndexChanged += new System.EventHandler(this.cmb_namaclub_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_namaclub);
            this.Controls.Add(this.combo_Nationality);
            this.Controls.Add(this.Label_Value);
            this.Controls.Add(this.LabelValue);
            this.Controls.Add(this.dgv_pemain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pemain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pemain;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.Label Label_Value;
        private System.Windows.Forms.ComboBox combo_Nationality;
        private System.Windows.Forms.ComboBox cmb_namaclub;
    }
}

