using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMS
{
    public partial class Student_Profile : MaterialSkin.Controls.MaterialForm
    {
        StudentDAO stdDao = new StudentDAO();
        bookDAO BDao = new bookDAO();

        public Student_Profile(string datas, string a, string b, string c, string d, string k, string f, string g, string h, string i, string j, string l, string m)
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            student_username_lbl.Text = datas;
            picshow();
            firstname_lbl.Text = b;
            lastname_lbl.Text = c;
            id_lbl.Text = a;
            contact_lbl.Text = d;
            username_lbl.Text = f;
            password_txt.Text = g;
            address_lbl.Text = h;
            dept_lbl.Text = i;
            bldgrp_lbl.Text = j;
            dob_lbl.Text = k;
            gender_lbl.Text = l;
            year_lbl.Text = m;
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        public int a, b, c, d, f, g, h, i, j;
        SqlConnection con = new SqlConnection(@"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlDataReader dr;

        private void show_result_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from result where id = '"+ id_lbl.Text +"' and semester ='"+ semester.Text +"'";
            SqlCommand cmd = new SqlCommand(query,con);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                materialLabel18.Text = (dr[1].ToString());
                materialLabel19.Text = (dr[2].ToString());
                materialLabel20.Text = (dr[3].ToString());
                materialLabel21.Text = (dr[4].ToString());
                materialLabel22.Text = (dr[5].ToString());
                materialLabel23.Text = (dr[6].ToString());
                materialLabel24.Text = (dr[7].ToString());
                materialLabel25.Text = (dr[8].ToString());
                materialLabel26.Text = (dr[9].ToString());
                materialLabel27.Text = (dr[10].ToString());
                con.Close();
            }
            else
            {
                materialLabel18.Text = "";
                materialLabel19.Text = "";
                materialLabel20.Text = "";
                materialLabel21.Text = "";
                materialLabel22.Text = "";
                materialLabel23.Text = "";
                materialLabel24.Text = "";
                materialLabel25.Text = "";
                materialLabel26.Text = "";
                materialLabel27.Text = "";
                MessageBox.Show("No result found for this semester...!");
                con.Close();
            }
        }

        private void requestbook_Click(object sender, EventArgs e)
        {
            string couno = courseno.Text;

            string bname = bookname.Text;

            string cname = coursename.Text;

            int quan = Convert.ToInt32(quantity.Text);

            string wri = writer.Text;

            String iid = id_lbl.Text;

            if (quan > 0)
            {
                quan = quan - 1;
                BDao.requestbook(new bookDTO(couno, bname, cname, quan, wri, iid));
                MessageBox.Show("We have received your request succesfully..!");
                BDao.updatequantity(quan, bname);
                this.booksTableAdapter.Fill(this.uMSDataSet.books);
                courseno.Text = "";
                bookname.Text = "";
                coursename.Text = "";
                quantity.Text = "";
                writer.Text = "";
            }

            else
            {
                MessageBox.Show("Not enough in quantity to serve..!");
                BDao.deletebook(bname);
                this.booksTableAdapter.Fill(this.uMSDataSet.books);
                courseno.Text = "";
                bookname.Text = "";
                coursename.Text = "";
                quantity.Text = "";
                writer.Text = "";
            }

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            courseno.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            bookname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            coursename.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            quantity.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            writer.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void sign_out_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you really want to Sign Out?");
            LogIn lg = new LogIn();
            this.Hide();
            lg.Show();
        }

        DataSet ds;

        public void picshow()
        {
            try
            {
                string sql = "SELECT image FROM student_tbl WHERE username = '" + student_username_lbl.Text + "'";
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        byte[] img = (byte[])(reader[0]);
                        if (img == null)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("image is not available");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void edit_profile_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            std_fname.Text = firstname_lbl.Text;
            lname.Text = lastname_lbl.Text;
            sd_id.Text = id_lbl.Text;
            std_contact.Text = contact_lbl.Text;
            std_user.Text = username_lbl.Text;
            std_password.Text = password_txt.Text;
            std_address.Text = address_lbl.Text;
            std_dept.Text = dept_lbl.Text;
            std_bld.Text = bldgrp_lbl.Text;
        }

        private void Student_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to close your program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void std_update_Click(object sender, EventArgs e)
        {
            String fname = std_fname.Text;
            String std_lname = lname.Text;
            String std_id = sd_id.Text;
            String contact = std_contact.Text;
            String user = std_user.Text;
            String std_pass = std_password.Text;
            String address = std_address.Text;
            String sd_dept = std_dept.Text;
            String sd_bld = std_bld.Text;

            // Edit_student_ProfileDAO.UpdateStudent(std_id);

            con.Open();
            string query = "UPDATE student_tbl SET first_name = '" + fname + "' , last_name = '" + std_lname + "' , mob = '" + contact + "',username = '" + user + "' , password = '" + std_pass + "' , address = '" + address + "', dept = '" + sd_dept + "' , blood = '" + sd_bld + "'  where id = '" + std_id + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Your Profile is updated..!");
            con.Close();
        }

        private void Student_Profile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uMSDataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.uMSDataSet.books);

        }


        private void pro_view_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            firstname_lbl.Text = std_fname.Text;
            lastname_lbl.Text = lname.Text;
            id_lbl.Text = sd_id.Text;
            contact_lbl.Text = std_contact.Text;
            username_lbl.Text = std_user.Text;
            password_txt.Text = std_password.Text;
            address_lbl.Text = std_address.Text;
            dept_lbl.Text = std_dept.Text;
            bldgrp_lbl.Text = std_bld.Text;
        }

        private void result_view_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
        }
    }
}
