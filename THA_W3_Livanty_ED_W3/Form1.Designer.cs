namespace THA_W3_Livanty_ED_W3
{
    partial class MainWindowForm
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
            this.button_opennextform = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_myfavartist = new System.Windows.Forms.TextBox();
            this.label_myfavartist = new System.Windows.Forms.Label();
            this.checkBox_allofthe = new System.Windows.Forms.CheckBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_opennextform
            // 
            this.button_opennextform.Location = new System.Drawing.Point(575, 370);
            this.button_opennextform.Name = "button_opennextform";
            this.button_opennextform.Size = new System.Drawing.Size(180, 43);
            this.button_opennextform.TabIndex = 0;
            this.button_opennextform.Text = "Open Next Form";
            this.button_opennextform.UseVisualStyleBackColor = true;
            this.button_opennextform.Click += new System.EventHandler(this.button_opennextform_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(65, 50);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(59, 20);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name: ";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(214, 50);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 26);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_myfavartist
            // 
            this.textBox_myfavartist.Location = new System.Drawing.Point(214, 94);
            this.textBox_myfavartist.Name = "textBox_myfavartist";
            this.textBox_myfavartist.Size = new System.Drawing.Size(100, 26);
            this.textBox_myfavartist.TabIndex = 3;
            // 
            // label_myfavartist
            // 
            this.label_myfavartist.AutoSize = true;
            this.label_myfavartist.Location = new System.Drawing.Point(64, 97);
            this.label_myfavartist.Name = "label_myfavartist";
            this.label_myfavartist.Size = new System.Drawing.Size(139, 20);
            this.label_myfavartist.TabIndex = 4;
            this.label_myfavartist.Text = "My Favorite Artist: ";
            // 
            // checkBox_allofthe
            // 
            this.checkBox_allofthe.AutoSize = true;
            this.checkBox_allofthe.Location = new System.Drawing.Point(51, 155);
            this.checkBox_allofthe.Name = "checkBox_allofthe";
            this.checkBox_allofthe.Size = new System.Drawing.Size(285, 24);
            this.checkBox_allofthe.TabIndex = 5;
            this.checkBox_allofthe.Text = "All of the content I put above is true";
            this.checkBox_allofthe.UseVisualStyleBackColor = true;
            this.checkBox_allofthe.CheckedChanged += new System.EventHandler(this.checkBox_allofthe_CheckedChanged);
            // 
            // button_submit
            // 
            this.button_submit.Enabled = false;
            this.button_submit.Location = new System.Drawing.Point(143, 199);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 30);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.checkBox_allofthe);
            this.Controls.Add(this.label_myfavartist);
            this.Controls.Add(this.textBox_myfavartist);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_opennextform);
            this.Name = "MainWindowForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_opennextform;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_myfavartist;
        private System.Windows.Forms.Label label_myfavartist;
        private System.Windows.Forms.CheckBox checkBox_allofthe;
        private System.Windows.Forms.Button button_submit;
    }
}

