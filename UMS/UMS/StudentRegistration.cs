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
    public partial class StudentRegistration : MaterialSkin.Controls.MaterialForm
    {
        public StudentRegistration()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        String gender;
        SqlConnection con = new SqlConnection(@"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");
        String imgLoc = "";
        SqlCommand command;

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
                    picture_student.ImageLocation = imgLoc;
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

        private void std_acnt_crt_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                if ((std_id.Text == "") || (std_firstname.Text == "") || (std_lastname.Text == "") || (picture_student.Image == null) || (std_mobnum.Text == "") || (std_username.Text == "") || (std_pass.Text == "") || (std_address.Text == "") || (std_dept.Text == "") || (std_bldgrp.Text == "") || (materialRadioButton1.Checked == false) && (materialRadioButton2.Checked == false) || (dateTimePicker1.Text == "") || (comboBox1.Text == ""))
                {
                    MessageBox.Show("One or more fields are empty...!");
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

                    String query = "INSERT INTO student_tbl (id,first_name,last_name,mob,username,password,address,dept,blood,dob,gender,year,image) VALUES ('" + std_id.Text + "','" + std_firstname.Text + "','" + std_lastname.Text + "','" + std_mobnum.Text + "','" + std_username.Text + "','" + std_pass.Text + "','" + std_address.Text + "','" + std_dept.Text + "','" + std_bldgrp.Text + "','" + dateTimePicker1.Text + "','" + gender + "','" + comboBox1.Text + "',@img)";
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        command = new SqlCommand(query, con);
                        command.Parameters.Add(new SqlParameter("@img", img));
                        int x = command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Account has created successfully!");
                        clear();
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void clear()
        {
            std_id.Text = "";
            std_firstname.Text = "";
            std_lastname.Text = "";
            comboBox1.Text = "";
            std_mobnum.Text = "";
            std_username.Text = "";
            std_pass.Text = "";
            std_address.Text = "";
            std_dept.Text = "";
            std_bldgrp.Text = "";
            materialRadioButton1.Checked = false;
            materialRadioButton2.Checked = false;
            dateTimePicker1.Text = "";
            picture_student.Image = null;
        }

        private void back_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            this.Hide();
            log.Show();
        }
    }
}
