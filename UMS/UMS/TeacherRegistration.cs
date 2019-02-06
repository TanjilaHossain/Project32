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
    public partial class TeacherRegistration : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");
        SqlCommand sqlCommand;
        TeacherDAO teacherDao = new TeacherDAO();
        SqlDataAdapter sqlDataAdapter;
        //DataTable dt;
        DataSet ds = new DataSet();
        String gender;
        String imgLoc = "";
        //SqlCommand command;
        int checking;

        public TeacherRegistration()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select a Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picture_teacher.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void t_acnt_crt_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                //int flag;
                if (materialRadioButton1.Checked)
                {
                    gender = "male";
                }

                else
                {
                    gender = "female";
                }





                /*

                                sqlConnection.Open();
                                TeacherDTO teacherDto = new TeacherDTO(t_id.Text, t_firstname.Text, t_lastname.Text, t_mobnum.Text, t_username.Text, t_pass.Text, t_address.Text, t_designation.Text, t_bldgrp.Text, gender, img);
                                String query ="select * from teacher_tbl where username='" + teacherDto.USERNAME + "'";
                                sqlCommand = new SqlCommand(query, sqlConnection);
                                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                                sqlDataAdapter.Fill(ds);
                                int count = ds.Tables[0].Rows.Count;

                                if (t_username.Text !="" && count > 0)
                                {
                                    checking = 1;
                                }
                                sqlConnection.Close();


                */












                if ((t_firstname.Text == "") || (t_lastname.Text == "") || (picture_teacher.Image == null) || (t_mobnum.Text == "") || (t_username.Text == "") || (t_pass.Text == "") || (t_confirmpass.Text == "") || (t_address.Text == "") || (t_designation.Text == "") || (t_dept.Text == "") || (t_bldgrp.Text == "") || (materialRadioButton1.Checked == false) && (materialRadioButton2.Checked == false))
                {
                    MessageBox.Show("One or more fields are empty...!");
                }
                else if (teacherDao.CheckTeacherExistance(new TeacherDTO(t_firstname.Text, t_lastname.Text, t_mobnum.Text, t_username.Text, t_pass.Text, t_address.Text, t_designation.Text, t_dept.Text, t_bldgrp.Text, gender, img)))
                {

                    MessageBox.Show("This username already exists!");
                    t_username.Text = "";
                    t_pass.Text = "";
                    t_confirmpass.Text = "";
                }
                else if (t_pass.Text != t_confirmpass.Text)
                {
                    t_pass.Text = "";
                    t_confirmpass.Text = "";
                }
                else
                {
                    if (materialRadioButton1.Checked)
                    {
                        gender = "male";
                    }

                    else
                    {
                        gender = "female";
                    }

                    String dept = t_dept.Text;
                    String f = t_firstname.Text;
                    String l = t_lastname.Text;
                    String m = t_mobnum.Text;
                    String u = t_username.Text;
                    String p = t_pass.Text;
                    String a = t_address.Text;
                    String d = t_designation.Text;
                    String b = t_bldgrp.Text;
                    String g = gender;
                    teacherDao.RegisterTeacher(new TeacherDTO(f, l, m, u, p, a, d, dept, b, g, img));
                    clear();

                }
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            t_dept.Text = "";
            t_firstname.Text = "";
            t_lastname.Text = "";
            t_mobnum.Text = "";
            t_username.Text = "";
            t_pass.Text = "";
            t_confirmpass.Text = "";
            t_address.Text = "";
            t_designation.Text = "";
            t_bldgrp.Text = "";
            materialRadioButton1.Checked = false;
            materialRadioButton2.Checked = false;
            picture_teacher.Image = null;
        }

        private void back_Click(object sender, EventArgs e)
        {
            //LibrarianRegistration r = new LibrarianRegistration();
            LogIn lg = new LogIn();
            this.Hide();
            lg.Show();
        }
    }
    
}
