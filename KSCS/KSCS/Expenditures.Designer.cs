namespace KSCS
{
    partial class Expenditures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenditures));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.datebox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.idno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.id = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.savebtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuMaterialTextbox6 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 703);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.save);
            this.tabPage1.Controls.Add(this.datebox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bunifuMaterialTextbox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.idno);
            this.tabPage1.Controls.Add(this.id);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 677);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Other Expenditures";
            // 
            // save
            // 
            this.save.ActiveBorderThickness = 1;
            this.save.ActiveCornerRadius = 20;
            this.save.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.save.ActiveForecolor = System.Drawing.Color.White;
            this.save.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.save.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.ButtonText = "SAVE";
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.SeaGreen;
            this.save.IdleBorderThickness = 1;
            this.save.IdleCornerRadius = 20;
            this.save.IdleFillColor = System.Drawing.Color.White;
            this.save.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.save.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.save.Location = new System.Drawing.Point(428, 439);
            this.save.Margin = new System.Windows.Forms.Padding(5);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(181, 41);
            this.save.TabIndex = 67;
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // datebox
            // 
            this.datebox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.datebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.datebox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.datebox.ForeColor = System.Drawing.Color.Black;
            this.datebox.HintForeColor = System.Drawing.Color.Silver;
            this.datebox.HintText = "";
            this.datebox.isPassword = false;
            this.datebox.LineFocusedColor = System.Drawing.Color.Blue;
            this.datebox.LineIdleColor = System.Drawing.Color.Gray;
            this.datebox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.datebox.LineThickness = 3;
            this.datebox.Location = new System.Drawing.Point(450, 288);
            this.datebox.Margin = new System.Windows.Forms.Padding(4);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(301, 33);
            this.datebox.TabIndex = 66;
            this.datebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Date:";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(450, 192);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(301, 33);
            this.bunifuMaterialTextbox1.TabIndex = 64;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Expenditure Amount:";
            // 
            // idno
            // 
            this.idno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.idno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idno.ForeColor = System.Drawing.Color.Black;
            this.idno.HintForeColor = System.Drawing.Color.Silver;
            this.idno.HintText = "";
            this.idno.isPassword = false;
            this.idno.LineFocusedColor = System.Drawing.Color.Blue;
            this.idno.LineIdleColor = System.Drawing.Color.Gray;
            this.idno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.idno.LineThickness = 3;
            this.idno.Location = new System.Drawing.Point(450, 96);
            this.idno.Margin = new System.Windows.Forms.Padding(4);
            this.idno.Name = "idno";
            this.idno.Size = new System.Drawing.Size(301, 33);
            this.idno.TabIndex = 62;
            this.idno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(270, 109);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(153, 20);
            this.id.TabIndex = 61;
            this.id.Text = "Expenditure Type:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.edit);
            this.tabPage2.Controls.Add(this.savebtn);
            this.tabPage2.Controls.Add(this.bunifuMaterialTextbox6);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.bunifuMaterialTextbox5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.bunifuMaterialTextbox4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.bunifuMaterialTextbox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bunifuMaterialTextbox3);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.bunifuDropdown1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1020, 677);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Farmer Expenditures";
            // 
            // edit
            // 
            this.edit.ActiveBorderThickness = 1;
            this.edit.ActiveCornerRadius = 20;
            this.edit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.edit.ActiveForecolor = System.Drawing.Color.White;
            this.edit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.edit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit.BackgroundImage")));
            this.edit.ButtonText = "Edit";
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.SeaGreen;
            this.edit.IdleBorderThickness = 1;
            this.edit.IdleCornerRadius = 20;
            this.edit.IdleFillColor = System.Drawing.Color.White;
            this.edit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.edit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.edit.Location = new System.Drawing.Point(598, 447);
            this.edit.Margin = new System.Windows.Forms.Padding(5);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(181, 41);
            this.edit.TabIndex = 76;
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // savebtn
            // 
            this.savebtn.ActiveBorderThickness = 1;
            this.savebtn.ActiveCornerRadius = 20;
            this.savebtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.savebtn.ActiveForecolor = System.Drawing.Color.White;
            this.savebtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.savebtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.savebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("savebtn.BackgroundImage")));
            this.savebtn.ButtonText = "Save";
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.savebtn.IdleBorderThickness = 1;
            this.savebtn.IdleCornerRadius = 20;
            this.savebtn.IdleFillColor = System.Drawing.Color.White;
            this.savebtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.savebtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.savebtn.Location = new System.Drawing.Point(252, 447);
            this.savebtn.Margin = new System.Windows.Forms.Padding(5);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(181, 41);
            this.savebtn.TabIndex = 75;
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuMaterialTextbox6
            // 
            this.bunifuMaterialTextbox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuMaterialTextbox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox6.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox6.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox6.HintText = "";
            this.bunifuMaterialTextbox6.isPassword = false;
            this.bunifuMaterialTextbox6.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox6.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox6.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox6.LineThickness = 3;
            this.bunifuMaterialTextbox6.Location = new System.Drawing.Point(666, 157);
            this.bunifuMaterialTextbox6.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox6.Name = "bunifuMaterialTextbox6";
            this.bunifuMaterialTextbox6.Size = new System.Drawing.Size(315, 33);
            this.bunifuMaterialTextbox6.TabIndex = 74;
            this.bunifuMaterialTextbox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(577, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 73;
            this.label10.Text = "Date:";
            // 
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox5.HintText = "";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox5.LineThickness = 3;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(666, 227);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(315, 33);
            this.bunifuMaterialTextbox5.TabIndex = 69;
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "Price:";
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox4.LineThickness = 3;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(666, 89);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(315, 33);
            this.bunifuMaterialTextbox4.TabIndex = 67;
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "To:";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox2.LineThickness = 3;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(118, 227);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(315, 33);
            this.bunifuMaterialTextbox2.TabIndex = 65;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Purpose:";
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.Black;
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Silver;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(118, 89);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(315, 33);
            this.bunifuMaterialTextbox3.TabIndex = 62;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 20);
            this.label15.TabIndex = 59;
            this.label15.Text = "Name:";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.AllowDrop = true;
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(118, 157);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuDropdown1.onHoverColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(315, 35);
            this.bunifuDropdown1.TabIndex = 58;
            // 
            // Expenditures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.tabControl1);
            this.Name = "Expenditures";
            this.Size = new System.Drawing.Size(1034, 706);
            this.Load += new System.EventHandler(this.Expenditures_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idno;
        private System.Windows.Forms.Label id;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox datebox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox6;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuThinButton2 save;
        private Bunifu.Framework.UI.BunifuThinButton2 savebtn;
        private Bunifu.Framework.UI.BunifuThinButton2 edit;
    }
}
