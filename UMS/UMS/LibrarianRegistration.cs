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
    public partial class LibrarianRegistration : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-6VBFHVH\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
        SqlCommand sqlCommand;
        LibrarianDAO librarianDao = new LibrarianDAO();
        SqlDataAdapter sqlDataAdapter;
        //DataTable dt;
        DataSet ds = new DataSet();
        String gender;
        String imgLoc = "";
        //SqlCommand command;
        int checking;

        public LibrarianRegistration()
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
                    picture_librarian.ImageLocation = imgLoc;
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

        private void L_acnt_crt_Click(object sender, EventArgs e)
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
                if ((L_firstname.Text == "") || (L_lastname.Text == "") || (picture_librarian.Image == null) || (L_username.Text == "") || (L_pass.Text == "") || (L_confirmpass.Text == "") || (materialRadioButton1.Checked == false) && (materialRadioButton2.Checked == false))
                {
                    MessageBox.Show("One or more fields are empty...!");
                }
                else if (librarianDao.CheckLibrarianExistance(new LibrarianDTO(L_firstname.Text, L_lastname.Text, L_username.Text, L_pass.Text, gender, img)))
                {

                    MessageBox.Show("This username already exists!");
                    L_username.Text = "";
                    L_pass.Text = "";
                    L_confirmpass.Text = "";
                }
                else if (L_pass.Text != L_confirmpass.Text)
                {
                    L_pass.Text = "";
                    L_confirmpass.Text = "";
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


                    String f = L_firstname.Text;
                    String l = L_lastname.Text;
                    String u = L_username.Text;
                    String p = L_pass.Text;
                    String g = gender;
                    librarianDao.RegisterLibrarian(new LibrarianDTO(f, l, u, p, g, img));

                    L_firstname.Text = "";
                    L_lastname.Text = "";
                    L_username.Text = "";
                    L_pass.Text = "";
                    materialRadioButton1.Checked = false;
                    materialRadioButton2.Checked = false;
                }
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            this.Hide();
            lg.Show();
        }

        private void LibrarianRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}