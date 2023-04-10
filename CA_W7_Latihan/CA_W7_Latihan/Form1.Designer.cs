namespace CA_W7_Latihan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.foodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodToolStripMenuItem,
            this.snackToolStripMenuItem,
            this.drinkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // foodToolStripMenuItem
            // 
            this.foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            this.foodToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.foodToolStripMenuItem.Text = "Food";
            this.foodToolStripMenuItem.Click += new System.EventHandler(this.foodToolStripMenuItem_Click);
            // 
            // snackToolStripMenuItem
            // 
            this.snackToolStripMenuItem.Name = "snackToolStripMenuItem";
            this.snackToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.snackToolStripMenuItem.Text = "Snack";
            this.snackToolStripMenuItem.Click += new System.EventHandler(this.snackToolStripMenuItem_Click);
            // 
            // drinkToolStripMenuItem
            // 
            this.drinkToolStripMenuItem.Name = "drinkToolStripMenuItem";
            this.drinkToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.drinkToolStripMenuItem.Text = "Drink";
            this.drinkToolStripMenuItem.Click += new System.EventHandler(this.drinkToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 320);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(588, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 428);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar Makanan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem foodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinkToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

