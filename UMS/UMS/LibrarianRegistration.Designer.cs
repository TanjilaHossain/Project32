namespace UMS
{
    partial class LibrarianRegistration
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
            this.L_confirmpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.browse_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.L_firstname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.L_acnt_crt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picture_librarian = new System.Windows.Forms.PictureBox();
            this.L_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.L_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.L_lastname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.picture_librarian)).BeginInit();
            this.SuspendLayout();
            // 
            // L_confirmpass
            // 
            this.L_confirmpass.Depth = 0;
            this.L_confirmpass.Hint = "Confirm Password";
            this.L_confirmpass.Location = new System.Drawing.Point(37, 199);
            this.L_confirmpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.L_confirmpass.Name = "L_confirmpass";
            this.L_confirmpass.PasswordChar = '\0';
            this.L_confirmpass.SelectedText = "";
            this.L_confirmpass.SelectionLength = 0;
            this.L_confirmpass.SelectionStart = 0;
            this.L_confirmpass.Size = new System.Drawing.Size(306, 23);
            this.L_confirmpass.TabIndex = 83;
            this.L_confirmpass.UseSystemPasswordChar = false;
            // 
            // browse_btn
            // 
            this.browse_btn.Depth = 0;
            this.browse_btn.Location = new System.Drawing.Point(37, 454);
            this.browse_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Primary = true;
            this.browse_btn.Size = new System.Drawing.Size(84, 23);
            this.browse_btn.TabIndex = 82;
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
            this.materialLabel1.Location = new System.Drawing.Point(37, 234);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(60, 19);
            this.materialLabel1.TabIndex = 81;
            this.materialLabel1.Text = " Gender";
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(269, 225);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(74, 30);
            this.materialRadioButton2.TabIndex = 80;
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
            this.materialRadioButton1.Location = new System.Drawing.Point(200, 225);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(59, 30);
            this.materialRadioButton1.TabIndex = 79;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "Male";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            this.materialRadioButton1.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // L_firstname
            // 
            this.L_firstname.Depth = 0;
            this.L_firstname.Hint = " First Name";
            this.L_firstname.Location = new System.Drawing.Point(37, 83);
            this.L_firstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.L_firstname.Name = "L_firstname";
            this.L_firstname.PasswordChar = '\0';
            this.L_firstname.SelectedText = "";
            this.L_firstname.SelectionLength = 0;
            this.L_firstname.SelectionStart = 0;
            this.L_firstname.Size = new System.Drawing.Size(306, 23);
            this.L_firstname.TabIndex = 78;
            this.L_firstname.UseSystemPasswordChar = false;
            // 
            // back
            // 
            this.back.Depth = 0;
            this.back.Location = new System.Drawing.Point(349, 506);
            this.back.MouseState = MaterialSkin.MouseState.HOVER;
            this.back.Name = "back";
            this.back.Primary = true;
            this.back.Size = new System.Drawing.Size(121, 49);
            this.back.TabIndex = 77;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // L_acnt_crt
            // 
            this.L_acnt_crt.Depth = 0;
            this.L_acnt_crt.Location = new System.Drawing.Point(41, 506);
            this.L_acnt_crt.MouseState = MaterialSkin.MouseState.HOVER;
            this.L_acnt_crt.Name = "L_acnt_crt";
            this.L_acnt_crt.Primary = true;
            this.L_acnt_crt.Size = new System.Drawing.Size(131, 49);
            this.L_acnt_crt.TabIndex = 76;
            this.L_acnt_crt.Text = "Create Account";
            this.L_acnt_crt.UseVisualStyleBackColor = true;
            this.L_acnt_crt.Click += new System.EventHandler(this.L_acnt_crt_Click);
            // 
            // picture_librarian
            // 
            this.picture_librarian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_librarian.Location = new System.Drawing.Point(131, 268);
            this.picture_librarian.Name = "picture_librarian";
            this.picture_librarian.Size = new System.Drawing.Size(212, 209);
            this.picture_librarian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_librarian.TabIndex = 75;
            this.picture_librarian.TabStop = false;
            // 
            // L_pass
            // 
            this.L_pass.Depth = 0;
            this.L_pass.Hint = " Password";
            this.L_pass.Location = new System.Drawing.Point(37, 170);
            this.L_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.L_pass.Name = "L_pass";
            this.L_pass.PasswordChar = '\0';
            this.L_pass.SelectedText = "";
            this.L_pass.SelectionLength = 0;
            this.L_pass.SelectionStart = 0;
            this.L_pass.Size = new System.Drawing.Size(306, 23);
            this.L_pass.TabIndex = 74;
            this.L_pass.UseSystemPasswordChar = false;
            // 
            // L_username
            // 
            this.L_username.Depth = 0;
            this.L_username.Hint = " Username";
            this.L_username.Location = new System.Drawing.Point(37, 141);
            this.L_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.L_username.Name = "L_username";
            this.L_username.PasswordChar = '\0';
            this.L_username.SelectedText = "";
            this.L_username.SelectionLength = 0;
            this.L_username.SelectionStart = 0;
            this.L_username.Size = new System.Drawing.Size(306, 23);
            this.L_username.TabIndex = 73;
            this.L_username.UseSystemPasswordChar = false;
            // 
            // L_lastname
            // 
            this.L_lastname.Depth = 0;
            this.L_lastname.Hint = " Last Name";
            this.L_lastname.Location = new System.Drawing.Point(37, 112);
            this.L_lastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.L_lastname.Name = "L_lastname";
            this.L_lastname.PasswordChar = '\0';
            this.L_lastname.SelectedText = "";
            this.L_lastname.SelectionLength = 0;
            this.L_lastname.SelectionStart = 0;
            this.L_lastname.Size = new System.Drawing.Size(306, 23);
            this.L_lastname.TabIndex = 72;
            this.L_lastname.UseSystemPasswordChar = false;
            // 
            // LibrarianRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 567);
            this.Controls.Add(this.L_confirmpass);
            this.Controls.Add(this.browse_btn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialRadioButton2);
            this.Controls.Add(this.materialRadioButton1);
            this.Controls.Add(this.L_firstname);
            this.Controls.Add(this.back);
            this.Controls.Add(this.L_acnt_crt);
            this.Controls.Add(this.picture_librarian);
            this.Controls.Add(this.L_pass);
            this.Controls.Add(this.L_username);
            this.Controls.Add(this.L_lastname);
            this.Name = "LibrarianRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrarianRegistration";
            this.Load += new System.EventHandler(this.LibrarianRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_librarian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField L_confirmpass;
        private MaterialSkin.Controls.MaterialRaisedButton browse_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField L_firstname;
        private MaterialSkin.Controls.MaterialRaisedButton back;
        private MaterialSkin.Controls.MaterialRaisedButton L_acnt_crt;
        private System.Windows.Forms.PictureBox picture_librarian;
        private MaterialSkin.Controls.MaterialSingleLineTextField L_pass;
        private MaterialSkin.Controls.MaterialSingleLineTextField L_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField L_lastname;
    }
}