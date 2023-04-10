namespace CA_W7_Latihan
{
    partial class form_snack
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
            this.button4 = new System.Windows.Forms.Button();
            this.btn_kentanggoreng = new System.Windows.Forms.Button();
            this.btn_tahu = new System.Windows.Forms.Button();
            this.btn_pokpok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(461, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 7;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_kentanggoreng
            // 
            this.btn_kentanggoreng.Location = new System.Drawing.Point(421, 72);
            this.btn_kentanggoreng.Name = "btn_kentanggoreng";
            this.btn_kentanggoreng.Size = new System.Drawing.Size(130, 80);
            this.btn_kentanggoreng.TabIndex = 6;
            this.btn_kentanggoreng.Text = "Kentang Goreng";
            this.btn_kentanggoreng.UseVisualStyleBackColor = true;
            // 
            // btn_tahu
            // 
            this.btn_tahu.Location = new System.Drawing.Point(246, 72);
            this.btn_tahu.Name = "btn_tahu";
            this.btn_tahu.Size = new System.Drawing.Size(142, 80);
            this.btn_tahu.TabIndex = 5;
            this.btn_tahu.Text = "Tahu Goreng";
            this.btn_tahu.UseVisualStyleBackColor = true;
            // 
            // btn_pokpok
            // 
            this.btn_pokpok.Location = new System.Drawing.Point(58, 72);
            this.btn_pokpok.Name = "btn_pokpok";
            this.btn_pokpok.Size = new System.Drawing.Size(165, 80);
            this.btn_pokpok.TabIndex = 4;
            this.btn_pokpok.Text = "Pok Pok";
            this.btn_pokpok.UseVisualStyleBackColor = true;
            // 
            // form_snack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 284);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_kentanggoreng);
            this.Controls.Add(this.btn_tahu);
            this.Controls.Add(this.btn_pokpok);
            this.Name = "form_snack";
            this.Text = "form_snack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_kentanggoreng;
        private System.Windows.Forms.Button btn_tahu;
        private System.Windows.Forms.Button btn_pokpok;
    }
}