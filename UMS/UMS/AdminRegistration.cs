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
    public partial class AdminRegistration : MaterialSkin.Controls.MaterialForm
    {
        public AdminRegistration()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

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
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picture_admin.ImageLocation = imgLoc;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc,FileMode.Open,FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                if((ad_id.Text =="")||(ad_fname.Text == "") || (ad_lastname.Text == "") || (picture_admin.Image == null) || (ad_mobnum.Text == "") || (ad_username.Text == "") || (ad_pass.Text == "") || (ad_address.Text == "") || (ad_dept.Text == "") || (ad_bldgrp.Text == "") || (ad_key.Text == ""))
                {
                    MessageBox.Show("One or more fields are empty...!");
                }
                else
                {
                    String query = "INSERT INTO admin_tbl (id,first_name,last_name,mob,username,password,address,dept,blood,passkey,image) VALUES ('" + ad_id.Text + "','" + ad_fname.Text + "','" + ad_lastname.Text + "','" + ad_mobnum.Text + "','" + ad_username.Text + "','" + ad_pass.Text + "','" + ad_address.Text + "','" + ad_dept.Text + "','" + ad_bldgrp.Text + "','" + ad_key.Text + "',@img)";
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                        command = new SqlCommand(query, con);
                        command.Parameters.Add(new SqlParameter("@img", img));
                        int x = command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Account has created successfully!");
                    }
                }
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            this.Hide();
            lg.Show();
        }
    }
}
