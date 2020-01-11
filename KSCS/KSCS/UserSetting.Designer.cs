namespace KSCS
{
    partial class UserSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSetting));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.users1 = new System.Windows.Forms.ComboBox();
            this.newpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.rpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.oldpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.users = new System.Windows.Forms.ComboBox();
            this.address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.phone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.cnic = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.status = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblstatu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.percent = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.txtpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtuser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDatabase = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtServer = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.backup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.udt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 703);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.updt);
            this.tabPage1.Controls.Add(this.users1);
            this.tabPage1.Controls.Add(this.newpass);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rpass);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.oldpass);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1023, 677);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Change Password";
            // 
            // updt
            // 
            this.updt.ActiveBorderThickness = 1;
            this.updt.ActiveCornerRadius = 20;
            this.updt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.updt.ActiveForecolor = System.Drawing.Color.White;
            this.updt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.updt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.updt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updt.BackgroundImage")));
            this.updt.ButtonText = "Update";
            this.updt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updt.ForeColor = System.Drawing.Color.SeaGreen;
            this.updt.IdleBorderThickness = 1;
            this.updt.IdleCornerRadius = 20;
            this.updt.IdleFillColor = System.Drawing.Color.White;
            this.updt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.updt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.updt.Location = new System.Drawing.Point(443, 555);
            this.updt.Margin = new System.Windows.Forms.Padding(5);
            this.updt.Name = "updt";
            this.updt.Size = new System.Drawing.Size(181, 41);
            this.updt.TabIndex = 85;
            this.updt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updt.Click += new System.EventHandler(this.updt_Click);
            // 
            // users1
            // 
            this.users1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.users1.FormattingEnabled = true;
            this.users1.Location = new System.Drawing.Point(419, 102);
            this.users1.Name = "users1";
            this.users1.Size = new System.Drawing.Size(315, 21);
            this.users1.TabIndex = 84;
            // 
            // newpass
            // 
            this.newpass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.newpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.newpass.ForeColor = System.Drawing.Color.Black;
            this.newpass.HintForeColor = System.Drawing.Color.Silver;
            this.newpass.HintText = "**********";
            this.newpass.isPassword = true;
            this.newpass.LineFocusedColor = System.Drawing.Color.Blue;
            this.newpass.LineIdleColor = System.Drawing.Color.Gray;
            this.newpass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.newpass.LineThickness = 3;
            this.newpass.Location = new System.Drawing.Point(419, 308);
            this.newpass.Margin = new System.Windows.Forms.Padding(4);
            this.newpass.Name = "newpass";
            this.newpass.Size = new System.Drawing.Size(315, 33);
            this.newpass.TabIndex = 68;
            this.newpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "New Password:";
            // 
            // rpass
            // 
            this.rpass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rpass.ForeColor = System.Drawing.Color.Black;
            this.rpass.HintForeColor = System.Drawing.Color.Silver;
            this.rpass.HintText = "**********";
            this.rpass.isPassword = true;
            this.rpass.LineFocusedColor = System.Drawing.Color.Blue;
            this.rpass.LineIdleColor = System.Drawing.Color.Gray;
            this.rpass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.rpass.LineThickness = 3;
            this.rpass.Location = new System.Drawing.Point(419, 416);
            this.rpass.Margin = new System.Windows.Forms.Padding(4);
            this.rpass.Name = "rpass";
            this.rpass.Size = new System.Drawing.Size(315, 33);
            this.rpass.TabIndex = 21;
            this.rpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Retype-Pass:";
            // 
            // oldpass
            // 
            this.oldpass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.oldpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.oldpass.ForeColor = System.Drawing.Color.Black;
            this.oldpass.HintForeColor = System.Drawing.Color.Silver;
            this.oldpass.HintText = "**********";
            this.oldpass.isPassword = true;
            this.oldpass.LineFocusedColor = System.Drawing.Color.Blue;
            this.oldpass.LineIdleColor = System.Drawing.Color.Gray;
            this.oldpass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.oldpass.LineThickness = 3;
            this.oldpass.Location = new System.Drawing.Point(419, 200);
            this.oldpass.Margin = new System.Windows.Forms.Padding(4);
            this.oldpass.Name = "oldpass";
            this.oldpass.Size = new System.Drawing.Size(315, 33);
            this.oldpass.TabIndex = 19;
            this.oldpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Old Password:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.udt);
            this.tabPage2.Controls.Add(this.users);
            this.tabPage2.Controls.Add(this.address);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.phone);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cnic);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.email);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.name);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1023, 677);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Info";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // users
            // 
            this.users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.users.FormattingEnabled = true;
            this.users.Location = new System.Drawing.Point(415, 52);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(315, 21);
            this.users.TabIndex = 87;
            this.users.SelectedIndexChanged += new System.EventHandler(this.users_SelectedIndexChanged);
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.address.ForeColor = System.Drawing.Color.Black;
            this.address.HintForeColor = System.Drawing.Color.Silver;
            this.address.HintText = "Kamienna 19B, 30-001 Kraków-Śródmieście, Poland";
            this.address.isPassword = false;
            this.address.LineFocusedColor = System.Drawing.Color.Blue;
            this.address.LineIdleColor = System.Drawing.Color.Gray;
            this.address.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.address.LineThickness = 3;
            this.address.Location = new System.Drawing.Point(415, 414);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(315, 33);
            this.address.TabIndex = 86;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(289, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 85;
            this.label9.Text = "Address:";
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.phone.ForeColor = System.Drawing.Color.Black;
            this.phone.HintForeColor = System.Drawing.Color.Silver;
            this.phone.HintText = "0000-0000000";
            this.phone.isPassword = false;
            this.phone.LineFocusedColor = System.Drawing.Color.Blue;
            this.phone.LineIdleColor = System.Drawing.Color.Gray;
            this.phone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.phone.LineThickness = 3;
            this.phone.Location = new System.Drawing.Point(415, 262);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(315, 33);
            this.phone.TabIndex = 84;
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Phone#";
            // 
            // cnic
            // 
            this.cnic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cnic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cnic.ForeColor = System.Drawing.Color.Black;
            this.cnic.HintForeColor = System.Drawing.Color.Silver;
            this.cnic.HintText = "00000-0000000-0";
            this.cnic.isPassword = false;
            this.cnic.LineFocusedColor = System.Drawing.Color.Blue;
            this.cnic.LineIdleColor = System.Drawing.Color.Gray;
            this.cnic.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cnic.LineThickness = 3;
            this.cnic.Location = new System.Drawing.Point(415, 338);
            this.cnic.Margin = new System.Windows.Forms.Padding(4);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(315, 33);
            this.cnic.TabIndex = 17;
            this.cnic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cnic:";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.HintForeColor = System.Drawing.Color.Silver;
            this.email.HintText = "abc123@gmail.com";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.Blue;
            this.email.LineIdleColor = System.Drawing.Color.Gray;
            this.email.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(415, 186);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(315, 33);
            this.email.TabIndex = 15;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email:";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.HintForeColor = System.Drawing.Color.Silver;
            this.name.HintText = "Aaaa Aaaaa";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.Blue;
            this.name.LineIdleColor = System.Drawing.Color.Gray;
            this.name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(415, 110);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(315, 33);
            this.name.TabIndex = 13;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage3.Controls.Add(this.status);
            this.tabPage3.Controls.Add(this.lblstatu);
            this.tabPage3.Controls.Add(this.percent);
            this.tabPage3.Controls.Add(this.ProgressBar1);
            this.tabPage3.Controls.Add(this.txtpassword);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtuser);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtDatabase);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtServer);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.backup);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1023, 677);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Backup";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(213, 608);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 13);
            this.status.TabIndex = 108;
            // 
            // lblstatu
            // 
            this.lblstatu.AutoSize = true;
            this.lblstatu.Location = new System.Drawing.Point(59, 608);
            this.lblstatu.Name = "lblstatu";
            this.lblstatu.Size = new System.Drawing.Size(40, 13);
            this.lblstatu.TabIndex = 107;
            this.lblstatu.Text = "Status:";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(404, 518);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(24, 13);
            this.percent.TabIndex = 106;
            this.percent.Text = "0 %";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar1.BorderRadius = 5;
            this.ProgressBar1.Location = new System.Drawing.Point(42, 448);
            this.ProgressBar1.MaximumValue = 100;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressBar1.Size = new System.Drawing.Size(750, 41);
            this.ProgressBar1.TabIndex = 105;
            this.ProgressBar1.Value = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.HintForeColor = System.Drawing.Color.Silver;
            this.txtpassword.HintText = "";
            this.txtpassword.isPassword = true;
            this.txtpassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtpassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtpassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtpassword.LineThickness = 3;
            this.txtpassword.Location = new System.Drawing.Point(404, 322);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(315, 33);
            this.txtpassword.TabIndex = 104;
            this.txtpassword.Text = "123";
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(238, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 103;
            this.label12.Text = "Password:";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtuser.ForeColor = System.Drawing.Color.Black;
            this.txtuser.HintForeColor = System.Drawing.Color.Silver;
            this.txtuser.HintText = "";
            this.txtuser.isPassword = false;
            this.txtuser.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtuser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtuser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtuser.LineThickness = 3;
            this.txtuser.Location = new System.Drawing.Point(404, 231);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(315, 33);
            this.txtuser.TabIndex = 102;
            this.txtuser.Text = "sa";
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(238, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 101;
            this.label11.Text = "User ID:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDatabase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDatabase.ForeColor = System.Drawing.Color.Black;
            this.txtDatabase.HintForeColor = System.Drawing.Color.Silver;
            this.txtDatabase.HintText = "";
            this.txtDatabase.isPassword = false;
            this.txtDatabase.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDatabase.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDatabase.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDatabase.LineThickness = 3;
            this.txtDatabase.Location = new System.Drawing.Point(404, 141);
            this.txtDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(315, 33);
            this.txtDatabase.TabIndex = 100;
            this.txtDatabase.Text = "KSCS";
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(238, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 99;
            this.label10.Text = "Database:";
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtServer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtServer.ForeColor = System.Drawing.Color.Black;
            this.txtServer.HintForeColor = System.Drawing.Color.Silver;
            this.txtServer.HintText = "";
            this.txtServer.isPassword = false;
            this.txtServer.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtServer.LineIdleColor = System.Drawing.Color.Gray;
            this.txtServer.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtServer.LineThickness = 3;
            this.txtServer.Location = new System.Drawing.Point(404, 58);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(315, 33);
            this.txtServer.TabIndex = 98;
            this.txtServer.Text = "DESKTOP-RK46RDQ\\SQLEXPRESS";
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 97;
            this.label5.Text = "Server:";
            // 
            // backup
            // 
            this.backup.ActiveBorderThickness = 1;
            this.backup.ActiveCornerRadius = 20;
            this.backup.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.backup.ActiveForecolor = System.Drawing.Color.White;
            this.backup.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.backup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backup.BackgroundImage")));
            this.backup.ButtonText = "Backup";
            this.backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backup.ForeColor = System.Drawing.Color.SeaGreen;
            this.backup.IdleBorderThickness = 1;
            this.backup.IdleCornerRadius = 20;
            this.backup.IdleFillColor = System.Drawing.Color.White;
            this.backup.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.backup.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.backup.Location = new System.Drawing.Point(815, 448);
            this.backup.Margin = new System.Windows.Forms.Padding(5);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(181, 41);
            this.backup.TabIndex = 0;
            this.backup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // udt
            // 
            this.udt.ActiveBorderThickness = 1;
            this.udt.ActiveCornerRadius = 20;
            this.udt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.udt.ActiveForecolor = System.Drawing.Color.White;
            this.udt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.udt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.udt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("udt.BackgroundImage")));
            this.udt.ButtonText = "Update";
            this.udt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.udt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udt.ForeColor = System.Drawing.Color.SeaGreen;
            this.udt.IdleBorderThickness = 1;
            this.udt.IdleCornerRadius = 20;
            this.udt.IdleFillColor = System.Drawing.Color.White;
            this.udt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.udt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.udt.Location = new System.Drawing.Point(437, 497);
            this.udt.Margin = new System.Windows.Forms.Padding(5);
            this.udt.Name = "udt";
            this.udt.Size = new System.Drawing.Size(181, 41);
            this.udt.TabIndex = 88;
            this.udt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.udt.Click += new System.EventHandler(this.udt_Click);
            // 
            // UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserSetting";
            this.Size = new System.Drawing.Size(1034, 706);
            this.Load += new System.EventHandler(this.UserSetting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cnic;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rpass;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox oldpass;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newpass;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox users1;
        private System.Windows.Forms.ComboBox users;
        private Bunifu.Framework.UI.BunifuThinButton2 updt;
        private System.Windows.Forms.TabPage tabPage3;
        private Bunifu.Framework.UI.BunifuThinButton2 backup;
        private Bunifu.Framework.UI.BunifuCustomLabel percent;
        private Bunifu.Framework.UI.BunifuProgressBar ProgressBar1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpassword;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtuser;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDatabase;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtServer;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomLabel status;
        private Bunifu.Framework.UI.BunifuCustomLabel lblstatu;
        private Bunifu.Framework.UI.BunifuThinButton2 udt;
    }
}
