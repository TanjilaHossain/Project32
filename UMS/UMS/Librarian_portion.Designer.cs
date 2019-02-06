namespace UMS
{
    partial class Librarian_portion
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
            this.return_books = new MaterialSkin.Controls.MaterialRaisedButton();
            this.view_request = new MaterialSkin.Controls.MaterialRaisedButton();
            this.L_deletebook = new MaterialSkin.Controls.MaterialRaisedButton();
            this.L_update = new MaterialSkin.Controls.MaterialRaisedButton();
            this.id_lbl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.insert_book = new MaterialSkin.Controls.MaterialRaisedButton();
            this.writer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.quantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.coursename = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bookname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.courseno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.booksTableAdapter = new UMS.UMSDataSet1TableAdapters.booksTableAdapter();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uMSDataSet1 = new UMS.UMSDataSet1();
            this.writerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sign_out = new MaterialSkin.Controls.MaterialRaisedButton();
            this.uMSDataSet5 = new UMS.UMSDataSet5();
            this.bookrequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookrequestTableAdapter = new UMS.UMSDataSet5TableAdapters.bookrequestTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.return_book = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ret_bname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.return_date = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.std_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cOURSENODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSENAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wRITERDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETURNDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuebooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uMSDataSet7 = new UMS.UMSDataSet7();
            this.issue_booksTableAdapter = new UMS.UMSDataSet7TableAdapters.issue_booksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMSDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrequestBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuebooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMSDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // return_books
            // 
            this.return_books.Depth = 0;
            this.return_books.Location = new System.Drawing.Point(592, 185);
            this.return_books.MouseState = MaterialSkin.MouseState.HOVER;
            this.return_books.Name = "return_books";
            this.return_books.Primary = true;
            this.return_books.Size = new System.Drawing.Size(114, 47);
            this.return_books.TabIndex = 11;
            this.return_books.Text = "RETURN BOOKS";
            this.return_books.UseVisualStyleBackColor = true;
            this.return_books.Click += new System.EventHandler(this.return_books_Click);
            // 
            // view_request
            // 
            this.view_request.Depth = 0;
            this.view_request.Location = new System.Drawing.Point(461, 238);
            this.view_request.MouseState = MaterialSkin.MouseState.HOVER;
            this.view_request.Name = "view_request";
            this.view_request.Primary = true;
            this.view_request.Size = new System.Drawing.Size(114, 47);
            this.view_request.TabIndex = 10;
            this.view_request.Text = "VIEW REQUESTS";
            this.view_request.UseVisualStyleBackColor = true;
            this.view_request.Click += new System.EventHandler(this.view_request_Click);
            // 
            // L_deletebook
            // 
            this.L_deletebook.Depth = 0;
            this.L_deletebook.Location = new System.Drawing.Point(329, 238);
            this.L_deletebook.MouseState = MaterialSkin.MouseState.HOVER;
            this.L_deletebook.Name = "L_deletebook";
            this.L_deletebook.Primary = true;
            this.L_deletebook.Size = new System.Drawing.Size(116, 48);
            this.L_deletebook.TabIndex = 9;
            this.L_deletebook.Text = "DELETE";
            this.L_deletebook.UseVisualStyleBackColor = true;
            this.L_deletebook.Click += new System.EventHandler(this.L_deletebook_Click);
            // 
            // L_update
            // 
            this.L_update.Depth = 0;
            this.L_update.Location = new System.Drawing.Point(461, 184);
            this.L_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.L_update.Name = "L_update";
            this.L_update.Primary = true;
            this.L_update.Size = new System.Drawing.Size(114, 48);
            this.L_update.TabIndex = 8;
            this.L_update.Text = "UPDATE";
            this.L_update.UseVisualStyleBackColor = true;
            this.L_update.Click += new System.EventHandler(this.L_update_Click);
            // 
            // id_lbl
            // 
            this.id_lbl.Depth = 0;
            this.id_lbl.Hint = "  Book id";
            this.id_lbl.Location = new System.Drawing.Point(376, 143);
            this.id_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.PasswordChar = '\0';
            this.id_lbl.SelectedText = "";
            this.id_lbl.SelectionLength = 0;
            this.id_lbl.SelectionStart = 0;
            this.id_lbl.Size = new System.Drawing.Size(274, 23);
            this.id_lbl.TabIndex = 7;
            this.id_lbl.UseSystemPasswordChar = false;
            // 
            // insert_book
            // 
            this.insert_book.Depth = 0;
            this.insert_book.Location = new System.Drawing.Point(329, 184);
            this.insert_book.MouseState = MaterialSkin.MouseState.HOVER;
            this.insert_book.Name = "insert_book";
            this.insert_book.Primary = true;
            this.insert_book.Size = new System.Drawing.Size(116, 48);
            this.insert_book.TabIndex = 6;
            this.insert_book.Text = "INSERT BOOK";
            this.insert_book.UseVisualStyleBackColor = true;
            this.insert_book.Click += new System.EventHandler(this.insert_book_Click);
            // 
            // writer
            // 
            this.writer.Depth = 0;
            this.writer.Hint = "  Writer";
            this.writer.Location = new System.Drawing.Point(376, 86);
            this.writer.MouseState = MaterialSkin.MouseState.HOVER;
            this.writer.Name = "writer";
            this.writer.PasswordChar = '\0';
            this.writer.SelectedText = "";
            this.writer.SelectionLength = 0;
            this.writer.SelectionStart = 0;
            this.writer.Size = new System.Drawing.Size(274, 23);
            this.writer.TabIndex = 5;
            this.writer.UseSystemPasswordChar = false;
            // 
            // quantity
            // 
            this.quantity.Depth = 0;
            this.quantity.Hint = "  Quantity";
            this.quantity.Location = new System.Drawing.Point(25, 254);
            this.quantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.quantity.Name = "quantity";
            this.quantity.PasswordChar = '\0';
            this.quantity.SelectedText = "";
            this.quantity.SelectionLength = 0;
            this.quantity.SelectionStart = 0;
            this.quantity.Size = new System.Drawing.Size(280, 23);
            this.quantity.TabIndex = 4;
            this.quantity.UseSystemPasswordChar = false;
            // 
            // coursename
            // 
            this.coursename.Depth = 0;
            this.coursename.Hint = "  Course Name";
            this.coursename.Location = new System.Drawing.Point(25, 199);
            this.coursename.MouseState = MaterialSkin.MouseState.HOVER;
            this.coursename.Name = "coursename";
            this.coursename.PasswordChar = '\0';
            this.coursename.SelectedText = "";
            this.coursename.SelectionLength = 0;
            this.coursename.SelectionStart = 0;
            this.coursename.Size = new System.Drawing.Size(280, 23);
            this.coursename.TabIndex = 3;
            this.coursename.UseSystemPasswordChar = false;
            // 
            // bookname
            // 
            this.bookname.Depth = 0;
            this.bookname.Hint = "  Book Name";
            this.bookname.Location = new System.Drawing.Point(25, 143);
            this.bookname.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookname.Name = "bookname";
            this.bookname.PasswordChar = '\0';
            this.bookname.SelectedText = "";
            this.bookname.SelectionLength = 0;
            this.bookname.SelectionStart = 0;
            this.bookname.Size = new System.Drawing.Size(280, 23);
            this.bookname.TabIndex = 2;
            this.bookname.UseSystemPasswordChar = false;
            // 
            // courseno
            // 
            this.courseno.Depth = 0;
            this.courseno.Hint = "  Course no.";
            this.courseno.Location = new System.Drawing.Point(25, 86);
            this.courseno.MouseState = MaterialSkin.MouseState.HOVER;
            this.courseno.Name = "courseno";
            this.courseno.PasswordChar = '\0';
            this.courseno.SelectedText = "";
            this.courseno.SelectionLength = 0;
            this.courseno.SelectionStart = 0;
            this.courseno.Size = new System.Drawing.Size(280, 23);
            this.courseno.TabIndex = 1;
            this.courseno.UseSystemPasswordChar = false;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "books";
            this.booksBindingSource.DataSource = this.uMSDataSet1;
            // 
            // uMSDataSet1
            // 
            this.uMSDataSet1.DataSetName = "UMSDataSet1";
            this.uMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // writerDataGridViewTextBoxColumn
            // 
            this.writerDataGridViewTextBoxColumn.DataPropertyName = "writer";
            this.writerDataGridViewTextBoxColumn.HeaderText = "writer";
            this.writerDataGridViewTextBoxColumn.Name = "writerDataGridViewTextBoxColumn";
            this.writerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "coursename";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "coursename";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            this.coursenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "bookname";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "bookname";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            this.booknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursenoDataGridViewTextBoxColumn
            // 
            this.coursenoDataGridViewTextBoxColumn.DataPropertyName = "courseno";
            this.coursenoDataGridViewTextBoxColumn.HeaderText = "courseno";
            this.coursenoDataGridViewTextBoxColumn.Name = "coursenoDataGridViewTextBoxColumn";
            this.coursenoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.coursenoDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.writerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(713, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // sign_out
            // 
            this.sign_out.Depth = 0;
            this.sign_out.Location = new System.Drawing.Point(592, 239);
            this.sign_out.MouseState = MaterialSkin.MouseState.HOVER;
            this.sign_out.Name = "sign_out";
            this.sign_out.Primary = true;
            this.sign_out.Size = new System.Drawing.Size(114, 46);
            this.sign_out.TabIndex = 12;
            this.sign_out.Text = "SIGN OUT";
            this.sign_out.UseVisualStyleBackColor = true;
            this.sign_out.Click += new System.EventHandler(this.sign_out_Click_1);
            // 
            // uMSDataSet5
            // 
            this.uMSDataSet5.DataSetName = "UMSDataSet5";
            this.uMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookrequestBindingSource
            // 
            this.bookrequestBindingSource.DataMember = "bookrequest";
            this.bookrequestBindingSource.DataSource = this.uMSDataSet5;
            // 
            // bookrequestTableAdapter
            // 
            this.bookrequestTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.return_book);
            this.panel1.Controls.Add(this.ret_bname);
            this.panel1.Controls.Add(this.return_date);
            this.panel1.Controls.Add(this.std_id);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(2, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 424);
            this.panel1.TabIndex = 13;
            // 
            // back
            // 
            this.back.Depth = 0;
            this.back.Location = new System.Drawing.Point(543, 77);
            this.back.MouseState = MaterialSkin.MouseState.HOVER;
            this.back.Name = "back";
            this.back.Primary = true;
            this.back.Size = new System.Drawing.Size(121, 47);
            this.back.TabIndex = 8;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // return_book
            // 
            this.return_book.Depth = 0;
            this.return_book.Location = new System.Drawing.Point(374, 77);
            this.return_book.MouseState = MaterialSkin.MouseState.HOVER;
            this.return_book.Name = "return_book";
            this.return_book.Primary = true;
            this.return_book.Size = new System.Drawing.Size(121, 47);
            this.return_book.TabIndex = 7;
            this.return_book.Text = "ISSUE RETURN";
            this.return_book.UseVisualStyleBackColor = true;
            this.return_book.Click += new System.EventHandler(this.return_book_Click);
            // 
            // ret_bname
            // 
            this.ret_bname.Depth = 0;
            this.ret_bname.Enabled = false;
            this.ret_bname.Hint = "  Book Name";
            this.ret_bname.Location = new System.Drawing.Point(374, 20);
            this.ret_bname.MouseState = MaterialSkin.MouseState.HOVER;
            this.ret_bname.Name = "ret_bname";
            this.ret_bname.PasswordChar = '\0';
            this.ret_bname.SelectedText = "";
            this.ret_bname.SelectionLength = 0;
            this.ret_bname.SelectionStart = 0;
            this.ret_bname.Size = new System.Drawing.Size(330, 23);
            this.ret_bname.TabIndex = 6;
            this.ret_bname.UseSystemPasswordChar = false;
            // 
            // return_date
            // 
            this.return_date.Depth = 0;
            this.return_date.Enabled = false;
            this.return_date.Hint = "Previous Quantity";
            this.return_date.Location = new System.Drawing.Point(23, 77);
            this.return_date.MouseState = MaterialSkin.MouseState.HOVER;
            this.return_date.Name = "return_date";
            this.return_date.PasswordChar = '\0';
            this.return_date.SelectedText = "";
            this.return_date.SelectionLength = 0;
            this.return_date.SelectionStart = 0;
            this.return_date.Size = new System.Drawing.Size(243, 23);
            this.return_date.TabIndex = 2;
            this.return_date.UseSystemPasswordChar = false;
            // 
            // std_id
            // 
            this.std_id.Depth = 0;
            this.std_id.Hint = "  Student Id";
            this.std_id.Location = new System.Drawing.Point(23, 20);
            this.std_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.std_id.Name = "std_id";
            this.std_id.PasswordChar = '\0';
            this.std_id.SelectedText = "";
            this.std_id.SelectionLength = 0;
            this.std_id.SelectionStart = 0;
            this.std_id.Size = new System.Drawing.Size(243, 23);
            this.std_id.TabIndex = 1;
            this.std_id.UseSystemPasswordChar = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cOURSENODataGridViewTextBoxColumn1,
            this.bOOKNAMEDataGridViewTextBoxColumn1,
            this.cOURSENAMEDataGridViewTextBoxColumn1,
            this.wRITERDataGridViewTextBoxColumn1,
            this.iDDataGridViewTextBoxColumn,
            this.rETURNDATEDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.issuebooksBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(713, 288);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDoubleClick_1);
            // 
            // cOURSENODataGridViewTextBoxColumn1
            // 
            this.cOURSENODataGridViewTextBoxColumn1.DataPropertyName = "COURSENO";
            this.cOURSENODataGridViewTextBoxColumn1.HeaderText = "COURSENO";
            this.cOURSENODataGridViewTextBoxColumn1.Name = "cOURSENODataGridViewTextBoxColumn1";
            this.cOURSENODataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bOOKNAMEDataGridViewTextBoxColumn1
            // 
            this.bOOKNAMEDataGridViewTextBoxColumn1.DataPropertyName = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn1.HeaderText = "BOOKNAME";
            this.bOOKNAMEDataGridViewTextBoxColumn1.Name = "bOOKNAMEDataGridViewTextBoxColumn1";
            this.bOOKNAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cOURSENAMEDataGridViewTextBoxColumn1
            // 
            this.cOURSENAMEDataGridViewTextBoxColumn1.DataPropertyName = "COURSENAME";
            this.cOURSENAMEDataGridViewTextBoxColumn1.HeaderText = "COURSENAME";
            this.cOURSENAMEDataGridViewTextBoxColumn1.Name = "cOURSENAMEDataGridViewTextBoxColumn1";
            this.cOURSENAMEDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // wRITERDataGridViewTextBoxColumn1
            // 
            this.wRITERDataGridViewTextBoxColumn1.DataPropertyName = "WRITER";
            this.wRITERDataGridViewTextBoxColumn1.HeaderText = "WRITER";
            this.wRITERDataGridViewTextBoxColumn1.Name = "wRITERDataGridViewTextBoxColumn1";
            this.wRITERDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rETURNDATEDataGridViewTextBoxColumn
            // 
            this.rETURNDATEDataGridViewTextBoxColumn.DataPropertyName = "RETURN_DATE";
            this.rETURNDATEDataGridViewTextBoxColumn.HeaderText = "RETURN_DATE";
            this.rETURNDATEDataGridViewTextBoxColumn.Name = "rETURNDATEDataGridViewTextBoxColumn";
            this.rETURNDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issuebooksBindingSource
            // 
            this.issuebooksBindingSource.DataMember = "issue_books";
            this.issuebooksBindingSource.DataSource = this.uMSDataSet7;
            // 
            // uMSDataSet7
            // 
            this.uMSDataSet7.DataSetName = "UMSDataSet7";
            this.uMSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issue_booksTableAdapter
            // 
            this.issue_booksTableAdapter.ClearBeforeFill = true;
            // 
            // Librarian_portion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sign_out);
            this.Controls.Add(this.return_books);
            this.Controls.Add(this.view_request);
            this.Controls.Add(this.L_deletebook);
            this.Controls.Add(this.L_update);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.insert_book);
            this.Controls.Add(this.writer);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.courseno);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Librarian_portion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian_portion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Librarian_portion_FormClosing);
            this.Load += new System.EventHandler(this.Librarian_portion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMSDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookrequestBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuebooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uMSDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton return_books;
        private MaterialSkin.Controls.MaterialRaisedButton view_request;
        private MaterialSkin.Controls.MaterialRaisedButton L_deletebook;
        private MaterialSkin.Controls.MaterialRaisedButton L_update;
        private MaterialSkin.Controls.MaterialSingleLineTextField id_lbl;
        private MaterialSkin.Controls.MaterialRaisedButton insert_book;
        private MaterialSkin.Controls.MaterialSingleLineTextField writer;
        private MaterialSkin.Controls.MaterialSingleLineTextField quantity;
        private MaterialSkin.Controls.MaterialSingleLineTextField coursename;
        private MaterialSkin.Controls.MaterialSingleLineTextField bookname;
        private MaterialSkin.Controls.MaterialSingleLineTextField courseno;
        private UMSDataSet1TableAdapters.booksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private UMSDataSet1 uMSDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn writerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton sign_out;
        private UMSDataSet5 uMSDataSet5;
        private System.Windows.Forms.BindingSource bookrequestBindingSource;
        private UMSDataSet5TableAdapters.bookrequestTableAdapter bookrequestTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private UMSDataSet7 uMSDataSet7;
        private System.Windows.Forms.BindingSource issuebooksBindingSource;
        private UMSDataSet7TableAdapters.issue_booksTableAdapter issue_booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSENODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSENAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wRITERDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETURNDATEDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialSingleLineTextField std_id;
        private MaterialSkin.Controls.MaterialRaisedButton return_book;
        private MaterialSkin.Controls.MaterialSingleLineTextField return_date;
        private MaterialSkin.Controls.MaterialRaisedButton back;
        private MaterialSkin.Controls.MaterialSingleLineTextField ret_bname;
    }
}