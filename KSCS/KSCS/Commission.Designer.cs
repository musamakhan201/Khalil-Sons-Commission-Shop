namespace KSCS
{
    partial class Commission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commission));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sve = new Bunifu.Framework.UI.BunifuThinButton2();
            this.date = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.comision = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.currentrate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.mktrate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.croptype = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1034, 706);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.sve);
            this.tabPage1.Controls.Add(this.date);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comision);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.currentrate);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.mktrate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.croptype);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1026, 680);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Commission";
            // 
            // sve
            // 
            this.sve.ActiveBorderThickness = 1;
            this.sve.ActiveCornerRadius = 20;
            this.sve.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.sve.ActiveForecolor = System.Drawing.Color.White;
            this.sve.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.sve.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sve.BackgroundImage")));
            this.sve.ButtonText = "SAVE";
            this.sve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sve.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sve.ForeColor = System.Drawing.Color.SeaGreen;
            this.sve.IdleBorderThickness = 1;
            this.sve.IdleCornerRadius = 20;
            this.sve.IdleFillColor = System.Drawing.Color.White;
            this.sve.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.sve.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.sve.Location = new System.Drawing.Point(452, 543);
            this.sve.Margin = new System.Windows.Forms.Padding(5);
            this.sve.Name = "sve";
            this.sve.Size = new System.Drawing.Size(181, 41);
            this.sve.TabIndex = 93;
            this.sve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sve.Click += new System.EventHandler(this.sve_Click);
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date.Enabled = false;
            this.date.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.HintForeColor = System.Drawing.Color.Silver;
            this.date.HintText = "";
            this.date.isPassword = false;
            this.date.LineFocusedColor = System.Drawing.Color.Blue;
            this.date.LineIdleColor = System.Drawing.Color.Gray;
            this.date.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.date.LineThickness = 3;
            this.date.Location = new System.Drawing.Point(438, 426);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(315, 33);
            this.date.TabIndex = 92;
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "Date:";
            // 
            // comision
            // 
            this.comision.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comision.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.comision.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comision.ForeColor = System.Drawing.Color.Black;
            this.comision.HintForeColor = System.Drawing.Color.Silver;
            this.comision.HintText = "Enter Percentage";
            this.comision.isPassword = false;
            this.comision.LineFocusedColor = System.Drawing.Color.Blue;
            this.comision.LineIdleColor = System.Drawing.Color.Gray;
            this.comision.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.comision.LineThickness = 3;
            this.comision.Location = new System.Drawing.Point(438, 277);
            this.comision.Margin = new System.Windows.Forms.Padding(4);
            this.comision.Name = "comision";
            this.comision.Size = new System.Drawing.Size(315, 33);
            this.comision.TabIndex = 89;
            this.comision.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.comision.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            this.comision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comision_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 88;
            this.label10.Text = "Commission:";
            // 
            // currentrate
            // 
            this.currentrate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.currentrate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentrate.Enabled = false;
            this.currentrate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.currentrate.ForeColor = System.Drawing.Color.Black;
            this.currentrate.HintForeColor = System.Drawing.Color.Silver;
            this.currentrate.HintText = "";
            this.currentrate.isPassword = false;
            this.currentrate.LineFocusedColor = System.Drawing.Color.Blue;
            this.currentrate.LineIdleColor = System.Drawing.Color.Gray;
            this.currentrate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.currentrate.LineThickness = 3;
            this.currentrate.Location = new System.Drawing.Point(438, 347);
            this.currentrate.Margin = new System.Windows.Forms.Padding(4);
            this.currentrate.Name = "currentrate";
            this.currentrate.Size = new System.Drawing.Size(315, 33);
            this.currentrate.TabIndex = 87;
            this.currentrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.currentrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentrate_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "Current Rate:";
            // 
            // mktrate
            // 
            this.mktrate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mktrate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mktrate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mktrate.ForeColor = System.Drawing.Color.Black;
            this.mktrate.HintForeColor = System.Drawing.Color.Silver;
            this.mktrate.HintText = "";
            this.mktrate.isPassword = false;
            this.mktrate.LineFocusedColor = System.Drawing.Color.Blue;
            this.mktrate.LineIdleColor = System.Drawing.Color.Gray;
            this.mktrate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.mktrate.LineThickness = 3;
            this.mktrate.Location = new System.Drawing.Point(438, 207);
            this.mktrate.Margin = new System.Windows.Forms.Padding(4);
            this.mktrate.Name = "mktrate";
            this.mktrate.Size = new System.Drawing.Size(315, 33);
            this.mktrate.TabIndex = 85;
            this.mktrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mktrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mktrate_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Market Rate:";
            // 
            // croptype
            // 
            this.croptype.AllowDrop = true;
            this.croptype.BackColor = System.Drawing.Color.Transparent;
            this.croptype.BorderRadius = 3;
            this.croptype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.croptype.DisabledColor = System.Drawing.Color.Gray;
            this.croptype.ForeColor = System.Drawing.Color.Black;
            this.croptype.Items = new string[] {
        "Select",
        "Wheat",
        "Cotton",
        "Rice",
        "Vegitables",
        "Fruits"};
            this.croptype.Location = new System.Drawing.Point(438, 135);
            this.croptype.Name = "croptype";
            this.croptype.NomalColor = System.Drawing.SystemColors.ButtonFace;
            this.croptype.onHoverColor = System.Drawing.SystemColors.ButtonFace;
            this.croptype.selectedIndex = 0;
            this.croptype.Size = new System.Drawing.Size(315, 35);
            this.croptype.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 82;
            this.label5.Text = "Crop Type:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1026, 680);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Profit/Loss";
            // 
            // Commission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.tabControl1);
            this.Name = "Commission";
            this.Size = new System.Drawing.Size(1034, 706);
            this.Load += new System.EventHandler(this.Commission_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox comision;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox currentrate;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mktrate;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown croptype;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox date;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 sve;
    }
}
