namespace UMS
{
    partial class TeacherRegistration
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
            this.t_dept = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.t_confirmpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.browse_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.t_firstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.t_acnt_crt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picture_teacher = new System.Windows.Forms.PictureBox();
            this.t_bldgrp = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.t_designation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.t_address = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.t_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.t_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.t_mobnum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.t_lastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.picture_teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // t_dept
            // 
            this.t_dept.Depth = 0;
            this.t_dept.Hint = "Department";
            this.t_dept.Location = new System.Drawing.Point(12, 487);
            this.t_dept.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_dept.Name = "t_dept";
            this.t_dept.PasswordChar = '\0';
            this.t_dept.SelectedText = "";
            this.t_dept.SelectionLength = 0;
            this.t_dept.SelectionStart = 0;
            this.t_dept.Size = new System.Drawing.Size(306, 23);
            this.t_dept.TabIndex = 73;
            this.t_dept.UseSystemPasswordChar = false;
            // 
            // t_confirmpass
            // 
            this.t_confirmpass.Depth = 0;
            this.t_confirmpass.Hint = "Confirm Password";
            this.t_confirmpass.Location = new System.Drawing.Point(12, 349);
            this.t_confirmpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_confirmpass.Name = "t_confirmpass";
            this.t_confirmpass.PasswordChar = '\0';
            this.t_confirmpass.SelectedText = "";
            this.t_confirmpass.SelectionLength = 0;
            this.t_confirmpass.SelectionStart = 0;
            this.t_confirmpass.Size = new System.Drawing.Size(306, 23);
            this.t_confirmpass.TabIndex = 72;
            this.t_confirmpass.UseSystemPasswordChar = false;
            // 
            // browse_btn
            // 
            this.browse_btn.Depth = 0;
            this.browse_btn.Location = new System.Drawing.Point(659, 80);
            this.browse_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Primary = true;
            this.browse_btn.Size = new System.Drawing.Size(84, 23);
            this.browse_btn.TabIndex = 71;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(477, 317);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 70;
            this.materialLabel1.Text = " Gender";
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(659, 312);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(74, 30);
            this.materialRadioButton2.TabIndex = 69;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "Female";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            this.materialRadioButton2.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(579, 312);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(59, 30);
            this.materialRadioButton1.TabIndex = 68;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Male";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // t_firstname
            // 
            this.t_firstname.Depth = 0;
            this.t_firstname.Hint = " First Name";
            this.t_firstname.Location = new System.Drawing.Point(12, 100);
            this.t_firstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_firstname.Name = "t_firstname";
            this.t_firstname.PasswordChar = '\0';
            this.t_firstname.SelectedText = "";
            this.t_firstname.SelectionLength = 0;
            this.t_firstname.SelectionStart = 0;
            this.t_firstname.Size = new System.Drawing.Size(306, 23);
            this.t_firstname.TabIndex = 67;
            this.t_firstname.UseSystemPasswordChar = false;
            // 
            // back
            // 
            this.back.Depth = 0;
            this.back.Location = new System.Drawing.Point(612, 440);
            this.back.MouseState = MaterialSkin.MouseState.HOVER;
            this.back.Name = "back";
            this.back.Primary = true;
            this.back.Size = new System.Drawing.Size(121, 49);
            this.back.TabIndex = 66;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // t_acnt_crt
            // 
            this.t_acnt_crt.Depth = 0;
            this.t_acnt_crt.Location = new System.Drawing.Point(426, 440);
            this.t_acnt_crt.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_acnt_crt.Name = "t_acnt_crt";
            this.t_acnt_crt.Primary = true;
            this.t_acnt_crt.Size = new System.Drawing.Size(131, 49);
            this.t_acnt_crt.TabIndex = 65;
            this.t_acnt_crt.Text = "Create Account";
            this.t_acnt_crt.UseVisualStyleBackColor = true;
            this.t_acnt_crt.Click += new System.EventHandler(this.t_acnt_crt_Click);
            // 
            // picture_teacher
            // 
            this.picture_teacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_teacher.Location = new System.Drawing.Point(426, 80);
            this.picture_teacher.Name = "picture_teacher";
            this.picture_teacher.Size = new System.Drawing.Size(212, 209);
            this.picture_teacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_teacher.TabIndex = 64;
            this.picture_teacher.TabStop = false;
            // 
            // t_bldgrp
            // 
            this.t_bldgrp.Depth = 0;
            this.t_bldgrp.Hint = " Blood Group";
            this.t_bldgrp.Location = new System.Drawing.Point(12, 533);
            this.t_bldgrp.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_bldgrp.Name = "t_bldgrp";
            this.t_bldgrp.PasswordChar = '\0';
            this.t_bldgrp.SelectedText = "";
            this.t_bldgrp.SelectionLength = 0;
            this.t_bldgrp.SelectionStart = 0;
            this.t_bldgrp.Size = new System.Drawing.Size(293, 23);
            this.t_bldgrp.TabIndex = 63;
            this.t_bldgrp.UseSystemPasswordChar = false;
            // 
            // t_designation
            // 
            this.t_designation.Depth = 0;
            this.t_designation.Hint = "Designation";
            this.t_designation.Location = new System.Drawing.Point(12, 440);
            this.t_designation.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_designation.Name = "t_designation";
            this.t_designation.PasswordChar = '\0';
            this.t_designation.SelectedText = "";
            this.t_designation.SelectionLength = 0;
            this.t_designation.SelectionStart = 0;
            this.t_designation.Size = new System.Drawing.Size(306, 23);
            this.t_designation.TabIndex = 62;
            this.t_designation.UseSystemPasswordChar = false;
            // 
            // t_address
            // 
            this.t_address.Depth = 0;
            this.t_address.Hint = " Address";
            this.t_address.Location = new System.Drawing.Point(12, 397);
            this.t_address.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_address.Name = "t_address";
            this.t_address.PasswordChar = '\0';
            this.t_address.SelectedText = "";
            this.t_address.SelectionLength = 0;
            this.t_address.SelectionStart = 0;
            this.t_address.Size = new System.Drawing.Size(375, 23);
            this.t_address.TabIndex = 61;
            this.t_address.UseSystemPasswordChar = false;
            // 
            // t_pass
            // 
            this.t_pass.Depth = 0;
            this.t_pass.Hint = " Password";
            this.t_pass.Location = new System.Drawing.Point(12, 301);
            this.t_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_pass.Name = "t_pass";
            this.t_pass.PasswordChar = '\0';
            this.t_pass.SelectedText = "";
            this.t_pass.SelectionLength = 0;
            this.t_pass.SelectionStart = 0;
            this.t_pass.Size = new System.Drawing.Size(306, 23);
            this.t_pass.TabIndex = 60;
            this.t_pass.UseSystemPasswordChar = false;
            // 
            // t_username
            // 
            this.t_username.Depth = 0;
            this.t_username.Hint = " Username";
            this.t_username.Location = new System.Drawing.Point(12, 256);
            this.t_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_username.Name = "t_username";
            this.t_username.PasswordChar = '\0';
            this.t_username.SelectedText = "";
            this.t_username.SelectionLength = 0;
            this.t_username.SelectionStart = 0;
            this.t_username.Size = new System.Drawing.Size(306, 23);
            this.t_username.TabIndex = 59;
            this.t_username.UseSystemPasswordChar = false;
            // 
            // t_mobnum
            // 
            this.t_mobnum.Depth = 0;
            this.t_mobnum.Hint = " Mobile No";
            this.t_mobnum.Location = new System.Drawing.Point(12, 204);
            this.t_mobnum.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_mobnum.Name = "t_mobnum";
            this.t_mobnum.PasswordChar = '\0';
            this.t_mobnum.SelectedText = "";
            this.t_mobnum.SelectionLength = 0;
            this.t_mobnum.SelectionStart = 0;
            this.t_mobnum.Size = new System.Drawing.Size(306, 23);
            this.t_mobnum.TabIndex = 58;
            this.t_mobnum.UseSystemPasswordChar = false;
            // 
            // t_lastname
            // 
            this.t_lastname.Depth = 0;
            this.t_lastname.Hint = " Last Name";
            this.t_lastname.Location = new System.Drawing.Point(12, 152);
            this.t_lastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_lastname.Name = "t_lastname";
            this.t_lastname.PasswordChar = '\0';
            this.t_lastname.SelectedText = "";
            this.t_lastname.SelectionLength = 0;
            this.t_lastname.SelectionStart = 0;
            this.t_lastname.Size = new System.Drawing.Size(306, 23);
            this.t_lastname.TabIndex = 57;
            this.t_lastname.UseSystemPasswordChar = false;
            // 
            // TeacherRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 563);
            this.Controls.Add(this.t_dept);
            this.Controls.Add(this.t_confirmpass);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRadioButton2);
            this.Controls.Add(this.materialRadioButton1);
            this.Controls.Add(this.t_firstname);
            this.Controls.Add(this.back);
            this.Controls.Add(this.t_acnt_crt);
            this.Controls.Add(this.picture_teacher);
            this.Controls.Add(this.t_bldgrp);
            this.Controls.Add(this.t_designation);
            this.Controls.Add(this.t_address);
            this.Controls.Add(this.t_pass);
            this.Controls.Add(this.t_username);
            this.Controls.Add(this.t_mobnum);
            this.Controls.Add(this.t_lastname);
            this.Name = "TeacherRegistration";
            this.Text = "TeacherRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.picture_teacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField t_dept;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_confirmpass;
        private MaterialSkin.Controls.MaterialRaisedButton browse_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_firstname;
        private MaterialSkin.Controls.MaterialRaisedButton back;
        private MaterialSkin.Controls.MaterialRaisedButton t_acnt_crt;
        private System.Windows.Forms.PictureBox picture_teacher;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_bldgrp;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_designation;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_address;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_pass;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_mobnum;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_lastname;
    }
}