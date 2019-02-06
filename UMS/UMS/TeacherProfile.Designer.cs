namespace UMS
{
    partial class TeacherProfile
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
            this.t_designation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.t_dept = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.t_submit_result = new MaterialSkin.Controls.MaterialRaisedButton();
            this.picture_teacher = new System.Windows.Forms.PictureBox();
            this.t_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picture_teacher)).BeginInit();
            this.SuspendLayout();
            // 
            // t_designation
            // 
            this.t_designation.Depth = 0;
            this.t_designation.Enabled = false;
            this.t_designation.Hint = "";
            this.t_designation.Location = new System.Drawing.Point(12, 393);
            this.t_designation.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_designation.Name = "t_designation";
            this.t_designation.PasswordChar = '\0';
            this.t_designation.SelectedText = "";
            this.t_designation.SelectionLength = 0;
            this.t_designation.SelectionStart = 0;
            this.t_designation.Size = new System.Drawing.Size(200, 23);
            this.t_designation.TabIndex = 74;
            this.t_designation.UseSystemPasswordChar = false;
            // 
            // t_dept
            // 
            this.t_dept.Depth = 0;
            this.t_dept.Enabled = false;
            this.t_dept.Hint = "";
            this.t_dept.Location = new System.Drawing.Point(12, 355);
            this.t_dept.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_dept.Name = "t_dept";
            this.t_dept.PasswordChar = '\0';
            this.t_dept.SelectedText = "";
            this.t_dept.SelectionLength = 0;
            this.t_dept.SelectionStart = 0;
            this.t_dept.Size = new System.Drawing.Size(200, 23);
            this.t_dept.TabIndex = 73;
            this.t_dept.UseSystemPasswordChar = false;
            // 
            // back
            // 
            this.back.Depth = 0;
            this.back.Location = new System.Drawing.Point(364, 105);
            this.back.MouseState = MaterialSkin.MouseState.HOVER;
            this.back.Name = "back";
            this.back.Primary = true;
            this.back.Size = new System.Drawing.Size(131, 49);
            this.back.TabIndex = 72;
            this.back.Text = "SIGNOUT";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // t_submit_result
            // 
            this.t_submit_result.Depth = 0;
            this.t_submit_result.Location = new System.Drawing.Point(218, 105);
            this.t_submit_result.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_submit_result.Name = "t_submit_result";
            this.t_submit_result.Primary = true;
            this.t_submit_result.Size = new System.Drawing.Size(131, 49);
            this.t_submit_result.TabIndex = 71;
            this.t_submit_result.Text = "Submit Result";
            this.t_submit_result.UseVisualStyleBackColor = true;
            this.t_submit_result.Click += new System.EventHandler(this.t_submit_result_Click);
            // 
            // picture_teacher
            // 
            this.picture_teacher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_teacher.Location = new System.Drawing.Point(12, 69);
            this.picture_teacher.Name = "picture_teacher";
            this.picture_teacher.Size = new System.Drawing.Size(200, 209);
            this.picture_teacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_teacher.TabIndex = 70;
            this.picture_teacher.TabStop = false;
            // 
            // t_name
            // 
            this.t_name.Depth = 0;
            this.t_name.Enabled = false;
            this.t_name.Hint = "";
            this.t_name.Location = new System.Drawing.Point(12, 312);
            this.t_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.t_name.Name = "t_name";
            this.t_name.PasswordChar = '\0';
            this.t_name.SelectedText = "";
            this.t_name.SelectionLength = 0;
            this.t_name.SelectionStart = 0;
            this.t_name.Size = new System.Drawing.Size(241, 23);
            this.t_name.TabIndex = 69;
            this.t_name.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 290);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 68;
            this.materialLabel1.Text = "Welcome :";
            // 
            // TeacherProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 439);
            this.Controls.Add(this.t_designation);
            this.Controls.Add(this.t_dept);
            this.Controls.Add(this.back);
            this.Controls.Add(this.t_submit_result);
            this.Controls.Add(this.picture_teacher);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.materialLabel1);
            this.Name = "TeacherProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeacherProfile";
            ((System.ComponentModel.ISupportInitialize)(this.picture_teacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField t_designation;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_dept;
        private MaterialSkin.Controls.MaterialRaisedButton back;
        private MaterialSkin.Controls.MaterialRaisedButton t_submit_result;
        private System.Windows.Forms.PictureBox picture_teacher;
        private MaterialSkin.Controls.MaterialSingleLineTextField t_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}