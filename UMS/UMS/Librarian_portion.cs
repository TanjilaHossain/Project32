using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMS
{
    public partial class Librarian_portion : MaterialSkin.Controls.MaterialForm
    {
        bookDAO BDao = new bookDAO();
        Library_manageDAO ldao = new Library_manageDAO();
        SqlConnection con = new SqlConnection(@"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");
        public int poriman;

        public Librarian_portion()
        {
            InitializeComponent();
            panel1.Visible = false;
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Librarian_portion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uMSDataSet7.issue_books' table. You can move, or remove it, as needed.
            this.issue_booksTableAdapter.Fill(this.uMSDataSet7.issue_books);
            // TODO: This line of code loads data into the 'uMSDataSet5.bookrequest' table. You can move, or remove it, as needed.
            this.bookrequestTableAdapter.Fill(this.uMSDataSet5.bookrequest);
            // TODO: This line of code loads data into the 'uMSDataSet1.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.uMSDataSet1.books);

        }

        private void Librarian_portion_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close your program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void insert_book_Click(object sender, EventArgs e)
        {
            if(courseno.Text == "" || bookname.Text == "" || quantity.Text == "" || writer.Text == "" || id_lbl.Text == "")
            {
                MessageBox.Show("One or more information is missing...!");
            }

            else
            {
                string couno = courseno.Text;

                string bname = bookname.Text;

                string cname = coursename.Text;

                int quan = Convert.ToInt32(quantity.Text);

                string wri = writer.Text;

                String iid = id_lbl.Text;

                BDao.insertbook(new bookDTO(couno, bname, cname, quan, wri, iid));
                MessageBox.Show("Book has successfully stored..!");
                this.booksTableAdapter.Fill(this.uMSDataSet1.books);
                courseno.Text = "";
                bookname.Text = "";
                coursename.Text = "";
                quantity.Text = "";
                writer.Text = "";
                id_lbl.Text = "";
            }
            
        }

        private void L_update_Click(object sender, EventArgs e)
        {
            string couno = courseno.Text;

            string bname = bookname.Text;

            string cname = coursename.Text;

            int quan = Convert.ToInt32(quantity.Text);

            string wri = writer.Text;

            String iid = id_lbl.Text;

            BDao.L_update_book(couno, bname, cname, quan, wri, iid);

            MessageBox.Show("Book informations have successfully updated..!");
            this.booksTableAdapter.Fill(this.uMSDataSet1.books);
            courseno.Text = "";
            bookname.Text = "";
            coursename.Text = "";
            quantity.Text = "";
            writer.Text = "";

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            courseno.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            bookname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            coursename.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            quantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            writer.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void L_deletebook_Click(object sender, EventArgs e)
        {
            string couno = courseno.Text;

            string bname = bookname.Text;

            string cname = coursename.Text;

            int quan = Convert.ToInt32(quantity.Text);

            string wri = writer.Text;

            String iid = id_lbl.Text;

            BDao.L_delete_book(bname);

            MessageBox.Show("Book informations have successfully Removed..!");
            this.booksTableAdapter.Fill(this.uMSDataSet1.books);
            courseno.Text = "";
            bookname.Text = "";
            coursename.Text = "";
            quantity.Text = "";
            writer.Text = "";
        }

        private void view_request_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true;
            Issue_books ib = new Issue_books();
            ib.Show();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void sign_out_Click(object sender, EventArgs e)
        {
           
        }

        private void sign_out_Click_1(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            MessageBox.Show("Do you really want to Sign Out?");
            this.Hide();
            lg.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            //panel1.Visible = false;
        }

       /* private void issue_book_Click(object sender, EventArgs e)
        {
            string couno = course_no.Text;

            string bname = book_name.Text;

            string cname = course_name.Text;

            string iid = std_id.Text;

            string wri = writer_2.Text;

            ldao.issuebook(new Library_manageDTO(couno, bname, cname,wri, iid));
            ldao.request_delete(iid);
            this.bookrequestTableAdapter.Fill(this.uMSDataSet5.bookrequest);
            MessageBox.Show("Book has successfully issued..!");
            course_no.Text = "";
            book_name.Text = "";
            course_name.Text = "";
            std_id.Text = "";
            writer_2.Text = "";
        }*/

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void return_books_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void return_book_Click(object sender, EventArgs e)
        {
            string bname = ret_bname.Text;
            string iid = std_id.Text;
            hello();
            return_date.Text = poriman.ToString();
            int quan = poriman;
            quan = quan + 1;
            BDao.delete_issue_book(iid);
            this.issue_booksTableAdapter.Fill(this.uMSDataSet7.issue_books);
            BDao.ret_update_book(bname,quan);
            this.booksTableAdapter.Fill(this.uMSDataSet1.books);
            MessageBox.Show("Book has stored successfully..!");
            con.Close();
            ret_bname.Text = "";
            return_date.Text = "";
            std_id.Text = "";
        }

        public void hello()
        {
            con.Open();
            String query = "SELECT * FROM books WHERE bookname = '" + ret_bname.Text +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                poriman = (Convert.ToInt32(dr[3]));
            }
            con.Close();
        }

        private void dataGridView2_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            std_id.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            ret_bname.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        /*private void dataGridView2_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            course_no.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            book_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            course_name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            writer_2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            std_id.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }*/
    }
}
