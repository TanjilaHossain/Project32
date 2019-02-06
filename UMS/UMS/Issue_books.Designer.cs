namespace UMS
{
    partial class Issue_books
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
            this.components = new System.ComponentModel.Container();
            this.course_no = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.book_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.course_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.writer_2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.std_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uMSDataSet6 = new UMS.UMSDataSet6();
            this.bookrequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookrequestTableAdapter = new UMS.UMSDataSet6TableAdapters.bookrequestTableAdapter();
            this.cOURSENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRITERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_book = new MaterialSkin.Controls.MaterialRaisedButton();
            this.back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMSDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // course_no
            // 
            this.course_no.Depth = 0;
            this.course_no.Enabled = false;
            this.course_no.Hint = "";
            this.course_no.Location = new System.Drawing.Point(30, 80);
            this.course_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.course_no.Name = "course_no";
            this.course_no.PasswordChar = '\0';
            this.course_no.SelectedText = "";
            this.course_no.SelectionLength = 0;
            this.course_no.SelectionStart = 0;
            this.course_no.Size = new System.Drawing.Size(297, 23);
            this.course_no.TabIndex = 0;
            this.course_no.UseSystemPasswordChar = false;
            // 
            // book_name
            // 
            this.book_name.Depth = 0;
            this.book_name.Enabled = false;
            this.book_name.Hint = "";
            this.book_name.Location = new System.Drawing.Point(30, 123);
            this.book_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.book_name.Name = "book_name";
            this.book_name.PasswordChar = '\0';
            this.book_name.SelectedText = "";
            this.book_name.SelectionLength = 0;
            this.book_name.SelectionStart = 0;
            this.book_name.Size = new System.Drawing.Size(297, 23);
            this.book_name.TabIndex = 1;
            this.book_name.UseSystemPasswordChar = false;
            // 
            // course_name
            // 
            this.course_name.Depth = 0;
            this.course_name.Enabled = false;
            this.course_name.Hint = "";
            this.course_name.Location = new System.Drawing.Point(30, 168);
            this.course_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.course_name.Name = "course_name";
            this.course_name.PasswordChar = '\0';
            this.course_name.SelectedText = "";
            this.course_name.SelectionLength = 0;
            this.course_name.SelectionStart = 0;
            this.course_name.Size = new System.Drawing.Size(297, 23);
            this.course_name.TabIndex = 2;
            this.course_name.UseSystemPasswordChar = false;
            // 
            // writer_2
            // 
            this.writer_2.Depth = 0;
            this.writer_2.Enabled = false;
            this.writer_2.Hint = "";
            this.writer_2.Location = new System.Drawing.Point(384, 132);
            this.writer_2.MouseState = MaterialSkin.MouseState.HOVER;
            this.writer_2.Name = "writer_2";
            this.writer_2.PasswordChar = '\0';
            this.writer_2.SelectedText = "";
            this.writer_2.SelectionLength = 0;
            this.writer_2.SelectionStart = 0;
            this.writer_2.Size = new System.Drawing.Size(287, 23);
            this.writer_2.TabIndex = 3;
            this.writer_2.UseSystemPasswordChar = false;
            // 
            // std_id
            // 
            this.std_id.Depth = 0;
            this.std_id.Enabled = false;
            this.std_id.Hint = "";
            this.std_id.Location = new System.Drawing.Point(384, 80);
            this.std_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_id.Name = "std_id";
            this.std_id.PasswordChar = '\0';
            this.std_id.SelectedText = "";
            this.std_id.SelectionLength = 0;
            this.std_id.SelectionStart = 0;
            this.std_id.Size = new System.Drawing.Size(287, 23);
            this.std_id.TabIndex = 4;
            this.std_id.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOURSENODataGridViewTextBoxColumn,
            this.bOOKNAMEDataGridViewTextBoxColumn,
            this.cOURSENAMEDataGridViewTextBoxColumn,
            this.wRITERDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookrequestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(677, 180);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // uMSDataSet6
            // 
            this.uMSDataSet6.DataSetName = "UMSDataSet6";
            this.uMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookrequestBindingSource
            // 
            this.bookrequestBindingSource.DataMember = "bookrequest";
            this.bookrequestBindingSource.DataSource = this.uMSDataSet6;
            // 
            // bookrequestTableAdapter
            // 
            this.bookrequestTableAdapter.ClearBeforeFill = true;
            // 
            // cOURSENODataGridViewTextBoxColumn
            // 
            this.cOURSENODataGridViewTextBoxColumn.DataPropertyName = "COURSENO";
            this.cOURSENODataGridViewTextBoxColumn.HeaderText = "COURSENO";
            this.cOURSENODataGridViewTextBoxColumn.Name = "cOURSENODataGridViewTextBoxColumn";
            this.cOURSENODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOOKNAMEDataGridViewTextBoxColumn
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn.DataPropertyName = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.HeaderText = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn.Name = "bOOKNAMEDataGridViewTextBoxColumn";
            this.bOOKNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOURSENAMEDataGridViewTextBoxColumn
            // 
            this.cOURSENAMEDataGridViewTextBoxColumn.DataPropertyName = "COURSENAME";
            this.cOURSENAMEDataGridViewTextBoxColumn.HeaderText = "COURSENAME";
            this.cOURSENAMEDataGridViewTextBoxColumn.Name = "cOURSENAMEDataGridViewTextBoxColumn";
            this.cOURSENAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wRITERDataGridViewTextBoxColumn
            // 
            this.wRITERDataGridViewTextBoxColumn.DataPropertyName = "WRITER";
            this.wRITERDataGridViewTextBoxColumn.HeaderText = "WRITER";
            this.wRITERDataGridViewTextBoxColumn.Name = "wRITERDataGridViewTextBoxColumn";
            this.wRITERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issue_book
            // 
            this.issue_book.Depth = 0;
            this.issue_book.Location = new System.Drawing.Point(384, 199);
            this.issue_book.MouseState = MaterialSkin.MouseState.HOVER;
            this.issue_book.Name = "issue_book";
            this.issue_book.Primary = true;
            this.issue_book.Size = new System.Drawing.Size(112, 44);
            this.issue_book.TabIndex = 6;
            this.issue_book.Text = "ISSUE BOOKS";
            this.issue_book.UseVisualStyleBackColor = true;
            this.issue_book.Click += new System.EventHandler(this.issue_book_Click);
            // 
            // back
            // 
            this.back.Depth = 0;
            this.back.Location = new System.Drawing.Point(538, 199);
            this.back.MouseState = MaterialSkin.MouseState.HOVER;
            this.back.Name = "back";
            this.back.Primary = true;
            this.back.Size = new System.Drawing.Size(113, 44);
            this.back.TabIndex = 7;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 209);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 209);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Return Date";
            // 
            // Issue_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 445);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.issue_book);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.std_id);
            this.Controls.Add(this.writer_2);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.book_name);
            this.Controls.Add(this.course_no);
            this.Name = "Issue_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue_books";
            this.Load += new System.EventHandler(this.Issue_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMSDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrequestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField course_no;
        private MaterialSkin.Controls.MaterialSingleLineTextField book_name;
        private MaterialSkin.Controls.MaterialSingleLineTextField course_name;
        private MaterialSkin.Controls.MaterialSingleLineTextField writer_2;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UMSDataSet6 uMSDataSet6;
        private System.Windows.Forms.BindingSource bookrequestBindingSource;
        private UMSDataSet6TableAdapters.bookrequestTableAdapter bookrequestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRITERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialRaisedButton issue_book;
        private MaterialSkin.Controls.MaterialRaisedButton back;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}