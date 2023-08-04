namespace EscolanoIntegrativeFinalEx
{
    partial class Edit
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
            this.button2 = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.txtbirthplace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpbdate = new System.Windows.Forms.DateTimePicker();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtext = new System.Windows.Forms.TextBox();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 80;
            this.button2.Text = "SAVE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(285, 287);
            this.txtemail.Name = "txtemail";
            this.txtemail.PlaceholderText = "Email";
            this.txtemail.Size = new System.Drawing.Size(201, 23);
            this.txtemail.TabIndex = 79;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(285, 235);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.PlaceholderText = "Contact No.";
            this.txtcontact.Size = new System.Drawing.Size(201, 23);
            this.txtcontact.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 77;
            this.label1.Text = "Gender";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(285, 173);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PlaceholderText = "Address";
            this.txtaddress.Size = new System.Drawing.Size(201, 39);
            this.txtaddress.TabIndex = 76;
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(285, 125);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(201, 23);
            this.cbgender.TabIndex = 75;
            // 
            // txtbirthplace
            // 
            this.txtbirthplace.Location = new System.Drawing.Point(285, 62);
            this.txtbirthplace.Multiline = true;
            this.txtbirthplace.Name = "txtbirthplace";
            this.txtbirthplace.PlaceholderText = "Birth Place";
            this.txtbirthplace.Size = new System.Drawing.Size(201, 34);
            this.txtbirthplace.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(66, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 73;
            this.label5.Text = "Birthdate";
            // 
            // dtpbdate
            // 
            this.dtpbdate.Location = new System.Drawing.Point(66, 288);
            this.dtpbdate.Name = "dtpbdate";
            this.dtpbdate.Size = new System.Drawing.Size(185, 23);
            this.dtpbdate.TabIndex = 72;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(66, 190);
            this.txtlname.Name = "txtlname";
            this.txtlname.PlaceholderText = "Last Name";
            this.txtlname.Size = new System.Drawing.Size(185, 23);
            this.txtlname.TabIndex = 71;
            // 
            // txtext
            // 
            this.txtext.Location = new System.Drawing.Point(66, 233);
            this.txtext.Name = "txtext";
            this.txtext.PlaceholderText = " Ext(Jr/Sr/II)";
            this.txtext.Size = new System.Drawing.Size(185, 23);
            this.txtext.TabIndex = 70;
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(66, 147);
            this.txtmname.Name = "txtmname";
            this.txtmname.PlaceholderText = "Middle Name";
            this.txtmname.Size = new System.Drawing.Size(185, 23);
            this.txtmname.TabIndex = 69;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(66, 104);
            this.txtfname.Name = "txtfname";
            this.txtfname.PlaceholderText = "First Name";
            this.txtfname.Size = new System.Drawing.Size(185, 23);
            this.txtfname.TabIndex = 68;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(66, 59);
            this.txtid.Name = "txtid";
            this.txtid.PlaceholderText = "Student ID NO.";
            this.txtid.Size = new System.Drawing.Size(185, 23);
            this.txtid.TabIndex = 67;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::EscolanoIntegrativeFinalEx.Properties.Resources.macos_minimize_24px;
            this.button1.Location = new System.Drawing.Point(493, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 27);
            this.button1.TabIndex = 82;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::EscolanoIntegrativeFinalEx.Properties.Resources.cancel_24px;
            this.button3.Location = new System.Drawing.Point(522, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 27);
            this.button3.TabIndex = 81;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(557, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtbirthplace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpbdate);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtext);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Edit_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Edit_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Edit_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button button2;
        public TextBox txtemail;
        public TextBox txtcontact;
        public Label label1;
        public TextBox txtaddress;
        public ComboBox cbgender;
        public TextBox txtbirthplace;
        public Label label5;
        public DateTimePicker dtpbdate;
        public TextBox txtlname;
        public TextBox txtext;
        public TextBox txtmname;
        public TextBox txtfname;
        public TextBox txtid;
        private Button button1;
        private Button button3;
    }
}