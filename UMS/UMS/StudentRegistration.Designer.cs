namespace UMS
{
    partial class StudentRegistration
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
            this.back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.std_acnt_crt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picture_student = new System.Windows.Forms.PictureBox();
            this.std_bldgrp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.std_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.std_dept = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.std_address = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.std_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.std_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.std_mobnum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.std_lastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.std_firstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.browse_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture_student)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Depth = 0;
            this.back.Location = new System.Drawing.Point(655, 488);
            this.back.MouseState = MaterialSkin.MouseState.HOVER;
            this.back.Name = "back";
            this.back.Primary = true;
            this.back.Size = new System.Drawing.Size(121, 49);
            this.back.TabIndex = 25;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // std_acnt_crt
            // 
            this.std_acnt_crt.Depth = 0;
            this.std_acnt_crt.Location = new System.Drawing.Point(482, 488);
            this.std_acnt_crt.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_acnt_crt.Name = "std_acnt_crt";
            this.std_acnt_crt.Primary = true;
            this.std_acnt_crt.Size = new System.Drawing.Size(131, 49);
            this.std_acnt_crt.TabIndex = 24;
            this.std_acnt_crt.Text = "Create Account";
            this.std_acnt_crt.UseVisualStyleBackColor = true;
            this.std_acnt_crt.Click += new System.EventHandler(this.std_acnt_crt_Click);
            // 
            // picture_student
            // 
            this.picture_student.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_student.Location = new System.Drawing.Point(469, 70);
            this.picture_student.Name = "picture_student";
            this.picture_student.Size = new System.Drawing.Size(212, 209);
            this.picture_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_student.TabIndex = 23;
            this.picture_student.TabStop = false;
            // 
            // std_bldgrp
            // 
            this.std_bldgrp.Depth = 0;
            this.std_bldgrp.Hint = " Blood Group";
            this.std_bldgrp.Location = new System.Drawing.Point(55, 514);
            this.std_bldgrp.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_bldgrp.Name = "std_bldgrp";
            this.std_bldgrp.PasswordChar = '\0';
            this.std_bldgrp.SelectedText = "";
            this.std_bldgrp.SelectionLength = 0;
            this.std_bldgrp.SelectionStart = 0;
            this.std_bldgrp.Size = new System.Drawing.Size(293, 23);
            this.std_bldgrp.TabIndex = 21;
            this.std_bldgrp.UseSystemPasswordChar = false;
            // 
            // std_id
            // 
            this.std_id.Depth = 0;
            this.std_id.Hint = " User ID";
            this.std_id.Location = new System.Drawing.Point(55, 466);
            this.std_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_id.Name = "std_id";
            this.std_id.PasswordChar = '\0';
            this.std_id.SelectedText = "";
            this.std_id.SelectionLength = 0;
            this.std_id.SelectionStart = 0;
            this.std_id.Size = new System.Drawing.Size(306, 23);
            this.std_id.TabIndex = 20;
            this.std_id.UseSystemPasswordChar = false;
            // 
            // std_dept
            // 
            this.std_dept.Depth = 0;
            this.std_dept.Hint = " Department";
            this.std_dept.Location = new System.Drawing.Point(55, 413);
            this.std_dept.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_dept.Name = "std_dept";
            this.std_dept.PasswordChar = '\0';
            this.std_dept.SelectedText = "";
            this.std_dept.SelectionLength = 0;
            this.std_dept.SelectionStart = 0;
            this.std_dept.Size = new System.Drawing.Size(306, 23);
            this.std_dept.TabIndex = 19;
            this.std_dept.UseSystemPasswordChar = false;
            // 
            // std_address
            // 
            this.std_address.Depth = 0;
            this.std_address.Hint = " Address";
            this.std_address.Location = new System.Drawing.Point(55, 358);
            this.std_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_address.Name = "std_address";
            this.std_address.PasswordChar = '\0';
            this.std_address.SelectedText = "";
            this.std_address.SelectionLength = 0;
            this.std_address.SelectionStart = 0;
            this.std_address.Size = new System.Drawing.Size(375, 23);
            this.std_address.TabIndex = 18;
            this.std_address.UseSystemPasswordChar = false;
            // 
            // std_pass
            // 
            this.std_pass.Depth = 0;
            this.std_pass.Hint = " Password";
            this.std_pass.Location = new System.Drawing.Point(55, 302);
            this.std_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_pass.Name = "std_pass";
            this.std_pass.PasswordChar = '\0';
            this.std_pass.SelectedText = "";
            this.std_pass.SelectionLength = 0;
            this.std_pass.SelectionStart = 0;
            this.std_pass.Size = new System.Drawing.Size(306, 23);
            this.std_pass.TabIndex = 17;
            this.std_pass.UseSystemPasswordChar = false;
            // 
            // std_username
            // 
            this.std_username.Depth = 0;
            this.std_username.Hint = " Username";
            this.std_username.Location = new System.Drawing.Point(55, 246);
            this.std_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_username.Name = "std_username";
            this.std_username.PasswordChar = '\0';
            this.std_username.SelectedText = "";
            this.std_username.SelectionLength = 0;
            this.std_username.SelectionStart = 0;
            this.std_username.Size = new System.Drawing.Size(306, 23);
            this.std_username.TabIndex = 16;
            this.std_username.UseSystemPasswordChar = false;
            // 
            // std_mobnum
            // 
            this.std_mobnum.Depth = 0;
            this.std_mobnum.Hint = " Mobile No";
            this.std_mobnum.Location = new System.Drawing.Point(55, 194);
            this.std_mobnum.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_mobnum.Name = "std_mobnum";
            this.std_mobnum.PasswordChar = '\0';
            this.std_mobnum.SelectedText = "";
            this.std_mobnum.SelectionLength = 0;
            this.std_mobnum.SelectionStart = 0;
            this.std_mobnum.Size = new System.Drawing.Size(306, 23);
            this.std_mobnum.TabIndex = 15;
            this.std_mobnum.UseSystemPasswordChar = false;
            // 
            // std_lastname
            // 
            this.std_lastname.Depth = 0;
            this.std_lastname.Hint = " Last Name";
            this.std_lastname.Location = new System.Drawing.Point(55, 142);
            this.std_lastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_lastname.Name = "std_lastname";
            this.std_lastname.PasswordChar = '\0';
            this.std_lastname.SelectedText = "";
            this.std_lastname.SelectionLength = 0;
            this.std_lastname.SelectionStart = 0;
            this.std_lastname.Size = new System.Drawing.Size(306, 23);
            this.std_lastname.TabIndex = 14;
            this.std_lastname.UseSystemPasswordChar = false;
            // 
            // std_firstname
            // 
            this.std_firstname.Depth = 0;
            this.std_firstname.Hint = " First Name";
            this.std_firstname.Location = new System.Drawing.Point(55, 90);
            this.std_firstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_firstname.Name = "std_firstname";
            this.std_firstname.PasswordChar = '\0';
            this.std_firstname.SelectedText = "";
            this.std_firstname.SelectionLength = 0;
            this.std_firstname.SelectionStart = 0;
            this.std_firstname.Size = new System.Drawing.Size(306, 23);
            this.std_firstname.TabIndex = 26;
            this.std_firstname.UseSystemPasswordChar = false;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(622, 302);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(59, 30);
            this.materialRadioButton1.TabIndex = 27;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Male";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(702, 302);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(74, 30);
            this.materialRadioButton2.TabIndex = 28;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Female";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1st year 1st semester",
            "1st year 2nd semester",
            "2nd year 1st semester",
            "2nd year 2nd semester",
            "3rd year 1st semester",
            "3rd year 2nd semester",
            "4th year 1st semester",
            "4th year 2nd semester"});
            this.comboBox1.Location = new System.Drawing.Point(622, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 28);
            this.comboBox1.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dateTimePicker1.CustomFormat = "dd - MM - yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(622, 413);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(165, 29);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(520, 307);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 31;
            this.materialLabel1.Text = " Gender";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(493, 358);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 19);
            this.materialLabel2.TabIndex = 32;
            this.materialLabel2.Text = "Year & Semester";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(557, 417);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(46, 19);
            this.materialLabel3.TabIndex = 33;
            this.materialLabel3.Text = "  DOB";
            // 
            // browse_btn
            // 
            this.browse_btn.Depth = 0;
            this.browse_btn.Location = new System.Drawing.Point(702, 70);
            this.browse_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Primary = true;
            this.browse_btn.Size = new System.Drawing.Size(84, 23);
            this.browse_btn.TabIndex = 34;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 553);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.materialRadioButton2);
            this.Controls.Add(this.materialRadioButton1);
            this.Controls.Add(this.std_firstname);
            this.Controls.Add(this.back);
            this.Controls.Add(this.std_acnt_crt);
            this.Controls.Add(this.picture_student);
            this.Controls.Add(this.std_bldgrp);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.std_dept);
            this.Controls.Add(this.std_address);
            this.Controls.Add(this.std_pass);
            this.Controls.Add(this.std_username);
            this.Controls.Add(this.std_mobnum);
            this.Controls.Add(this.std_lastname);
            this.Name = "StudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            ((System.ComponentModel.ISupportInitialize)(this.picture_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton back;
        private MaterialSkin.Controls.MaterialRaisedButton std_acnt_crt;
        private System.Windows.Forms.PictureBox picture_student;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_bldgrp;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_id;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_dept;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_address;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_pass;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_mobnum;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_lastname;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_firstname;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton browse_btn;
    }
}