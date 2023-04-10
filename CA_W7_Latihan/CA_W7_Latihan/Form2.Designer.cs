namespace CA_W7_Latihan
{
    partial class form_food
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
            this.btn_nasgor = new System.Windows.Forms.Button();
            this.btn_migor = new System.Windows.Forms.Button();
            this.btn_baksogoreng = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_nasgor
            // 
            this.btn_nasgor.Location = new System.Drawing.Point(30, 95);
            this.btn_nasgor.Name = "btn_nasgor";
            this.btn_nasgor.Size = new System.Drawing.Size(165, 80);
            this.btn_nasgor.TabIndex = 0;
            this.btn_nasgor.Text = "Nasi Goreng";
            this.btn_nasgor.UseVisualStyleBackColor = true;
            // 
            // btn_migor
            // 
            this.btn_migor.Location = new System.Drawing.Point(218, 95);
            this.btn_migor.Name = "btn_migor";
            this.btn_migor.Size = new System.Drawing.Size(142, 80);
            this.btn_migor.TabIndex = 1;
            this.btn_migor.Text = "Mie Goreng";
            this.btn_migor.UseVisualStyleBackColor = true;
            // 
            // btn_baksogoreng
            // 
            this.btn_baksogoreng.Location = new System.Drawing.Point(393, 95);
            this.btn_baksogoreng.Name = "btn_baksogoreng";
            this.btn_baksogoreng.Size = new System.Drawing.Size(130, 80);
            this.btn_baksogoreng.TabIndex = 2;
            this.btn_baksogoreng.Text = "Bakso Goreng";
            this.btn_baksogoreng.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(433, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // form_food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(572, 264);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_baksogoreng);
            this.Controls.Add(this.btn_migor);
            this.Controls.Add(this.btn_nasgor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_food";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_nasgor;
        private System.Windows.Forms.Button btn_migor;
        private System.Windows.Forms.Button btn_baksogoreng;
        private System.Windows.Forms.Button button4;
    }
}