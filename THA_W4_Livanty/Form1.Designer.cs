namespace THA_W4_Livanty
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
            this.lbl_soccerteamlist = new System.Windows.Forms.Label();
            this.lbl_choosecountry = new System.Windows.Forms.Label();
            this.lbl_chooseteam = new System.Windows.Forms.Label();
            this.lbl_teamcountry = new System.Windows.Forms.Label();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.lbl_addingteam = new System.Windows.Forms.Label();
            this.cmb_choosecountry = new System.Windows.Forms.ComboBox();
            this.cmb_chooseteam = new System.Windows.Forms.ComboBox();
            this.lbl_teamcity = new System.Windows.Forms.Label();
            this.txt_teamname = new System.Windows.Forms.TextBox();
            this.txt_teamcity = new System.Windows.Forms.TextBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_playernumber = new System.Windows.Forms.TextBox();
            this.txt_playername = new System.Windows.Forms.TextBox();
            this.lbl_playerposition = new System.Windows.Forms.Label();
            this.lbl_addingplayer = new System.Windows.Forms.Label();
            this.lbl_playername = new System.Windows.Forms.Label();
            this.lbl_playernumber = new System.Windows.Forms.Label();
            this.btn_addteam = new System.Windows.Forms.Button();
            this.btn_addplayer = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.listBox_hasil = new System.Windows.Forms.ListBox();
            this.cmb_playerpositiom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_soccerteamlist
            // 
            this.lbl_soccerteamlist.AutoSize = true;
            this.lbl_soccerteamlist.Location = new System.Drawing.Point(39, 71);
            this.lbl_soccerteamlist.Name = "lbl_soccerteamlist";
            this.lbl_soccerteamlist.Size = new System.Drawing.Size(132, 20);
            this.lbl_soccerteamlist.TabIndex = 0;
            this.lbl_soccerteamlist.Text = "Soccer Team List";
            // 
            // lbl_choosecountry
            // 
            this.lbl_choosecountry.AutoSize = true;
            this.lbl_choosecountry.Location = new System.Drawing.Point(38, 103);
            this.lbl_choosecountry.Name = "lbl_choosecountry";
            this.lbl_choosecountry.Size = new System.Drawing.Size(127, 20);
            this.lbl_choosecountry.TabIndex = 1;
            this.lbl_choosecountry.Text = "Choose Country:";
            // 
            // lbl_chooseteam
            // 
            this.lbl_chooseteam.AutoSize = true;
            this.lbl_chooseteam.Location = new System.Drawing.Point(40, 155);
            this.lbl_chooseteam.Name = "lbl_chooseteam";
            this.lbl_chooseteam.Size = new System.Drawing.Size(112, 20);
            this.lbl_chooseteam.TabIndex = 2;
            this.lbl_chooseteam.Text = "Choose Team:";
            // 
            // lbl_teamcountry
            // 
            this.lbl_teamcountry.AutoSize = true;
            this.lbl_teamcountry.Location = new System.Drawing.Point(307, 145);
            this.lbl_teamcountry.Name = "lbl_teamcountry";
            this.lbl_teamcountry.Size = new System.Drawing.Size(112, 20);
            this.lbl_teamcountry.TabIndex = 3;
            this.lbl_teamcountry.Text = "Team Country:";
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Location = new System.Drawing.Point(307, 103);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(99, 20);
            this.lbl_teamname.TabIndex = 4;
            this.lbl_teamname.Text = "Team Name:";
            // 
            // lbl_addingteam
            // 
            this.lbl_addingteam.AutoSize = true;
            this.lbl_addingteam.Location = new System.Drawing.Point(362, 46);
            this.lbl_addingteam.Name = "lbl_addingteam";
            this.lbl_addingteam.Size = new System.Drawing.Size(103, 20);
            this.lbl_addingteam.TabIndex = 5;
            this.lbl_addingteam.Text = "Adding Team";
            // 
            // cmb_choosecountry
            // 
            this.cmb_choosecountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_choosecountry.FormattingEnabled = true;
            this.cmb_choosecountry.Location = new System.Drawing.Point(162, 103);
            this.cmb_choosecountry.Name = "cmb_choosecountry";
            this.cmb_choosecountry.Size = new System.Drawing.Size(121, 28);
            this.cmb_choosecountry.TabIndex = 6;
            this.cmb_choosecountry.SelectedIndexChanged += new System.EventHandler(this.cmb_choosecountry_SelectedIndexChanged_1);
            // 
            // cmb_chooseteam
            // 
            this.cmb_chooseteam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_chooseteam.FormattingEnabled = true;
            this.cmb_chooseteam.Location = new System.Drawing.Point(162, 155);
            this.cmb_chooseteam.Name = "cmb_chooseteam";
            this.cmb_chooseteam.Size = new System.Drawing.Size(121, 28);
            this.cmb_chooseteam.TabIndex = 7;
            this.cmb_chooseteam.SelectedIndexChanged += new System.EventHandler(this.cmb_chooseteam_SelectedIndexChanged);
            // 
            // lbl_teamcity
            // 
            this.lbl_teamcity.AutoSize = true;
            this.lbl_teamcity.Location = new System.Drawing.Point(307, 192);
            this.lbl_teamcity.Name = "lbl_teamcity";
            this.lbl_teamcity.Size = new System.Drawing.Size(83, 20);
            this.lbl_teamcity.TabIndex = 8;
            this.lbl_teamcity.Text = "Team City:";
            // 
            // txt_teamname
            // 
            this.txt_teamname.Location = new System.Drawing.Point(425, 103);
            this.txt_teamname.Name = "txt_teamname";
            this.txt_teamname.Size = new System.Drawing.Size(100, 26);
            this.txt_teamname.TabIndex = 9;
            // 
            // txt_teamcity
            // 
            this.txt_teamcity.Location = new System.Drawing.Point(425, 189);
            this.txt_teamcity.Name = "txt_teamcity";
            this.txt_teamcity.Size = new System.Drawing.Size(100, 26);
            this.txt_teamcity.TabIndex = 10;
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(425, 142);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(100, 26);
            this.txt_country.TabIndex = 11;
            // 
            // txt_playernumber
            // 
            this.txt_playernumber.Location = new System.Drawing.Point(667, 139);
            this.txt_playernumber.Name = "txt_playernumber";
            this.txt_playernumber.Size = new System.Drawing.Size(100, 26);
            this.txt_playernumber.TabIndex = 18;
            // 
            // txt_playername
            // 
            this.txt_playername.Location = new System.Drawing.Point(667, 103);
            this.txt_playername.Name = "txt_playername";
            this.txt_playername.Size = new System.Drawing.Size(100, 26);
            this.txt_playername.TabIndex = 16;
            // 
            // lbl_playerposition
            // 
            this.lbl_playerposition.AutoSize = true;
            this.lbl_playerposition.Location = new System.Drawing.Point(545, 195);
            this.lbl_playerposition.Name = "lbl_playerposition";
            this.lbl_playerposition.Size = new System.Drawing.Size(116, 20);
            this.lbl_playerposition.TabIndex = 15;
            this.lbl_playerposition.Text = "Player Position:";
            // 
            // lbl_addingplayer
            // 
            this.lbl_addingplayer.AutoSize = true;
            this.lbl_addingplayer.Location = new System.Drawing.Point(620, 46);
            this.lbl_addingplayer.Name = "lbl_addingplayer";
            this.lbl_addingplayer.Size = new System.Drawing.Size(106, 20);
            this.lbl_addingplayer.TabIndex = 14;
            this.lbl_addingplayer.Text = "Adding Player";
            // 
            // lbl_playername
            // 
            this.lbl_playername.AutoSize = true;
            this.lbl_playername.Location = new System.Drawing.Point(545, 103);
            this.lbl_playername.Name = "lbl_playername";
            this.lbl_playername.Size = new System.Drawing.Size(102, 20);
            this.lbl_playername.TabIndex = 13;
            this.lbl_playername.Text = "Player Name:";
            // 
            // lbl_playernumber
            // 
            this.lbl_playernumber.AutoSize = true;
            this.lbl_playernumber.Location = new System.Drawing.Point(545, 145);
            this.lbl_playernumber.Name = "lbl_playernumber";
            this.lbl_playernumber.Size = new System.Drawing.Size(116, 20);
            this.lbl_playernumber.TabIndex = 12;
            this.lbl_playernumber.Text = "Player Number:";
            // 
            // btn_addteam
            // 
            this.btn_addteam.Location = new System.Drawing.Point(379, 233);
            this.btn_addteam.Name = "btn_addteam";
            this.btn_addteam.Size = new System.Drawing.Size(75, 34);
            this.btn_addteam.TabIndex = 19;
            this.btn_addteam.Text = "Add";
            this.btn_addteam.UseVisualStyleBackColor = true;
            this.btn_addteam.Click += new System.EventHandler(this.btn_addteam_Click);
            // 
            // btn_addplayer
            // 
            this.btn_addplayer.Location = new System.Drawing.Point(624, 233);
            this.btn_addplayer.Name = "btn_addplayer";
            this.btn_addplayer.Size = new System.Drawing.Size(75, 34);
            this.btn_addplayer.TabIndex = 20;
            this.btn_addplayer.Text = "Add";
            this.btn_addplayer.UseVisualStyleBackColor = true;
            this.btn_addplayer.Click += new System.EventHandler(this.btn_addplayer_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(44, 403);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(108, 35);
            this.btn_remove.TabIndex = 21;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // listBox_hasil
            // 
            this.listBox_hasil.FormattingEnabled = true;
            this.listBox_hasil.ItemHeight = 20;
            this.listBox_hasil.Location = new System.Drawing.Point(44, 244);
            this.listBox_hasil.Name = "listBox_hasil";
            this.listBox_hasil.Size = new System.Drawing.Size(258, 144);
            this.listBox_hasil.TabIndex = 22;
            // 
            // cmb_playerpositiom
            // 
            this.cmb_playerpositiom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_playerpositiom.FormattingEnabled = true;
            this.cmb_playerpositiom.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.cmb_playerpositiom.Location = new System.Drawing.Point(667, 187);
            this.cmb_playerpositiom.Name = "cmb_playerpositiom";
            this.cmb_playerpositiom.Size = new System.Drawing.Size(121, 28);
            this.cmb_playerpositiom.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_playerpositiom);
            this.Controls.Add(this.listBox_hasil);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_addplayer);
            this.Controls.Add(this.btn_addteam);
            this.Controls.Add(this.txt_playernumber);
            this.Controls.Add(this.txt_playername);
            this.Controls.Add(this.lbl_playerposition);
            this.Controls.Add(this.lbl_addingplayer);
            this.Controls.Add(this.lbl_playername);
            this.Controls.Add(this.lbl_playernumber);
            this.Controls.Add(this.txt_country);
            this.Controls.Add(this.txt_teamcity);
            this.Controls.Add(this.txt_teamname);
            this.Controls.Add(this.lbl_teamcity);
            this.Controls.Add(this.cmb_chooseteam);
            this.Controls.Add(this.cmb_choosecountry);
            this.Controls.Add(this.lbl_addingteam);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.lbl_teamcountry);
            this.Controls.Add(this.lbl_chooseteam);
            this.Controls.Add(this.lbl_choosecountry);
            this.Controls.Add(this.lbl_soccerteamlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_soccerteamlist;
        private System.Windows.Forms.Label lbl_choosecountry;
        private System.Windows.Forms.Label lbl_chooseteam;
        private System.Windows.Forms.Label lbl_teamcountry;
        private System.Windows.Forms.Label lbl_teamname;
        private System.Windows.Forms.Label lbl_addingteam;
        private System.Windows.Forms.ComboBox cmb_choosecountry;
        private System.Windows.Forms.ComboBox cmb_chooseteam;
        private System.Windows.Forms.Label lbl_teamcity;
        private System.Windows.Forms.TextBox txt_teamname;
        private System.Windows.Forms.TextBox txt_teamcity;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.TextBox txt_playernumber;
        private System.Windows.Forms.TextBox txt_playername;
        private System.Windows.Forms.Label lbl_playerposition;
        private System.Windows.Forms.Label lbl_addingplayer;
        private System.Windows.Forms.Label lbl_playername;
        private System.Windows.Forms.Label lbl_playernumber;
        private System.Windows.Forms.Button btn_addteam;
        private System.Windows.Forms.Button btn_addplayer;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ListBox listBox_hasil;
        private System.Windows.Forms.ComboBox cmb_playerpositiom;
    }
}

