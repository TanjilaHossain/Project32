using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMS
{
    public partial class Category : MaterialSkin.Controls.MaterialForm
    {
        string category;

        public Category()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }
    
        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            category = "admin";
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            category = "teacher";
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            category = "student";
        }

        private void materialRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            category = "librarian";
        }

        private void materialRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            category = "alumni";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(category=="admin")
            {
                AdminRegistration adm = new AdminRegistration();
                this.Hide();
                adm.Show();
            }

            else if (category == "student")
            {
                StudentRegistration std = new StudentRegistration();
                this.Hide();
                std.Show();
            }

            else if (category == "teacher")
            {
                TeacherRegistration tec = new TeacherRegistration();
                this.Hide();
                tec.Show();
            }

            else if (category == "librarian")
            {
                LibrarianRegistration lib = new LibrarianRegistration();
                this.Hide();
                lib.Show();
            }

            else if (category == "alumni")
            {
                AlumniRegistration alm = new AlumniRegistration();
                this.Hide();
                alm.Show();
            }
        }

        private void Category_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to close your program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cat_back_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            this.Hide();
            log.Show();
        }
    }
}
