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
    public partial class Admin_Portion : MaterialSkin.Controls.MaterialForm
    {
        AdminDAO adDao = new AdminDAO();

        public Admin_Portion(string Datas,string a,string b, string c, string d,string k, string f, string g, string h, string i, string j)
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            admin_username_lbl.Text = Datas;
            picshow();
            firstname_lbl.Text = b;
            lastname_lbl.Text = c;
            id_lbl .Text= a;
            contact_lbl.Text = d;
            username_lbl.Text = f;
            password_txt.Text = g;
            address_lbl.Text = h;
            dept_lbl.Text = i;
            bldgrp_lbl.Text = j;
            key_lbl.Text = k;
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        SqlConnection con = new SqlConnection(@"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");

        public void picshow()
        {
            try
            {
                string sql = "SELECT image FROM admin_tbl WHERE username = '" + admin_username_lbl.Text + "'";
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pro_pic_show_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void edit_profile_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void Admin_Portion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uMSDataSet11.result' table. You can move, or remove it, as needed.
            this.resultTableAdapter.Fill(this.uMSDataSet11.result);
            // TODO: This line of code loads data into the 'uMSDataSet10.marks_tbl' table. You can move, or remove it, as needed.
            this.marks_tblTableAdapter.Fill(this.uMSDataSet10.marks_tbl);
            // TODO: This line of code loads data into the 'uMSDataSet9.teacher_tbl' table. You can move, or remove it, as needed.
            this.teacher_tblTableAdapter.Fill(this.uMSDataSet9.teacher_tbl);
            // TODO: This line of code loads data into the 'uMSDataSet8.student_tbl' table. You can move, or remove it, as needed.
            this.student_tblTableAdapter.Fill(this.uMSDataSet8.student_tbl);

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            f_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            mark.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
        }

        private void approve_acnt_Click(object sender, EventArgs e)
        {
            string iid = id.Text;
            string fname = f_name.Text;

            adDao.approve_acnt(iid);
            this.student_tblTableAdapter.Fill(this.uMSDataSet8.student_tbl);
            MessageBox.Show("Account is now activated...!");
            id.Text = "";
            f_name.Text = "";
            mark.Text = "";
        }

        private void ad_std_delete_Click(object sender, EventArgs e)
        {
            string iid = id_2.Text;

            adDao.delete_acnt(iid);
            this.student_tblTableAdapter.Fill(this.uMSDataSet8.student_tbl);
            MessageBox.Show("Account has removed successfully...!");
            id_2.Text = "";
            materialSingleLineTextField2.Text = "";
            materialSingleLineTextField3.Text = "";
            materialSingleLineTextField4.Text = "";
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id_2.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            materialSingleLineTextField2.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            materialSingleLineTextField3.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            materialSingleLineTextField4.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void ad_delete_student_Click(object sender, EventArgs e)
        {
            //panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void dataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mob.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            user_name.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void ad_delete_teacher_Click(object sender, EventArgs e)
        {
            string mb = mob.Text;
            string user = user_name.Text;

            adDao.delete_teacher_acnt(mb,user);
            this.teacher_tblTableAdapter.Fill(this.uMSDataSet9.teacher_tbl);
            MessageBox.Show("Account has removed successfully...!");
            mob.Text = "";
            user_name.Text = "";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void record_result_Click(object sender, EventArgs e)
        {
            string subject1 = sub_1.Text;
            string subject2 = sub_2.Text;
            string subject3 = sub_3.Text;
            string subject4 = sub_4.Text;
            string subject5 = sub_5.Text;
            string subject6 = lab_1.Text;
            string subject7 = lab_2.Text;
            string subject8 = lab_3.Text;
            string subject9 = lab_4.Text;
            string iid = id_3.Text;
            string th = thesis.Text;
            string sem = semester.Text;
            //adDao.record_result(new adminDTO(subject1,subject2,subject3,subject4,subject5,subject6,subject7,subject8,subject9,iid,th));
            adDao.update_result(subject1, subject2, subject3, subject4, subject5, subject6, subject7, subject8, subject9, iid, th,sem);
            MessageBox.Show("Result is Recorded succesfully...!");
            this.resultTableAdapter.Fill(this.uMSDataSet11.result);
            sub_1.Text = "";
            sub_2.Text = "";
            sub_3.Text = "";
            sub_4.Text = "";
            sub_5.Text = "";
            lab_1.Text = "";
            lab_2.Text = "";
            lab_3.Text = "";
            lab_4.Text = "";
            id_3.Text = "";
            thesis.Text = "";
            semester.Text = "";
        }

        private void dataGridView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id_3.Text = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            sub_1.Text = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            sub_2.Text = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();
            sub_3.Text = dataGridView4.SelectedRows[0].Cells[3].Value.ToString();
            sub_4.Text = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
            sub_5.Text = dataGridView4.SelectedRows[0].Cells[5].Value.ToString();
            lab_1.Text = dataGridView4.SelectedRows[0].Cells[6].Value.ToString();
            lab_2.Text = dataGridView4.SelectedRows[0].Cells[7].Value.ToString();
            lab_3.Text = dataGridView4.SelectedRows[0].Cells[8].Value.ToString();
            lab_4.Text = dataGridView4.SelectedRows[0].Cells[9].Value.ToString();
            thesis.Text = dataGridView4.SelectedRows[0].Cells[10].Value.ToString();
            semester.Text = dataGridView4.SelectedRows[0].Cells[11].Value.ToString();
        }

        private void manage_result_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void ad_signout_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            this.Hide();
            lg.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            string subject1 = sub_1.Text;
            string subject2 = sub_2.Text;
            string subject3 = sub_3.Text;
            string subject4 = sub_4.Text;
            string subject5 = sub_5.Text;
            string subject6 = lab_1.Text;
            string subject7 = lab_2.Text;
            string subject8 = lab_3.Text;
            string subject9 = lab_4.Text;
            string iid = id_3.Text;
            string th = thesis.Text;
            string sem = semester.Text;

            adDao.insert_result(new adminDTO(subject1, subject2, subject3, subject4, subject5, subject6, subject7, subject8, subject9, iid, th,sem));
            MessageBox.Show("Result has recorder succesfully...!");
            this.resultTableAdapter.Fill(this.uMSDataSet11.result);
            sub_1.Text = "";
            sub_2.Text = "";
            sub_3.Text = "";
            sub_4.Text = "";
            sub_5.Text = "";
            lab_1.Text = "";
            lab_2.Text = "";
            lab_3.Text = "";
            lab_4.Text = "";
            id_3.Text = "";
            thesis.Text = "";
            semester.Text = "";
        }
    }
}
