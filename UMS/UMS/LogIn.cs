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
    public partial class LogIn : MaterialSkin.Controls.MaterialForm
    {
        Librarian_portion L = new Librarian_portion();
        String category;
        String a, b, c, d, k, f, g, h, i, j, l, m, n;
        string active = "1";

        public LogIn()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        SqlConnection con = new SqlConnection(@"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");

   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Category cat = new Category();
            this.Hide();
            cat.Show();
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you really want to close your program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            category = "admin";
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            category = "teacher";
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            category = "student";
        }

        private void materialRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            category = "librarian";
        }

        private void login_all_Click(object sender, EventArgs e)
        {
            try
            {
                if (category == "admin")
                {
                    if ((username_all.Text == "") || (password_all.Text == ""))
                    {
                        MessageBox.Show("One or more informations are missing..!");
                        clear();
                    }
                    else
                    {
                        con.Open();
                        String query = "SELECT * FROM admin_tbl WHERE username = '" + username_all.Text.Trim() + "' AND password ='" + password_all.Text.Trim() + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            a = (dr[0].ToString());
                            b = (dr[1].ToString());
                            c = (dr[2].ToString());
                            d = (dr[3].ToString());
                            f = (dr[4].ToString());
                            g = (dr[5].ToString());
                            h = (dr[6].ToString());
                            i = (dr[7].ToString());
                            j = (dr[8].ToString());
                            k = (dr[9].ToString());

                            if (username_all.Text == f && password_all.Text == g)
                            {
                                //Console.WriteLine("here1");
                                MessageBox.Show("You are logged in!");
                                con.Close();
                                Admin_Portion adp = new Admin_Portion(username_all.Text, a, b, c, d, k, f, g, h, i, j);
                                this.Hide();
                                adp.Show();
                            }
                            //Console.WriteLine("here3");
                        }
                        else if (username_all.Text != f || password_all.Text != g)
                        {
                            //Console.WriteLine("here2");
                            MessageBox.Show("One or more fields are empty..!");
                            con.Close();
                        }
                    }

                }

                else if (category == "student")
                {
                    con.Open();
                    String query = "SELECT * FROM student_tbl WHERE username = '" + username_all.Text.Trim() + "' AND password ='" + password_all.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        a = (dr[0].ToString());
                        b = (dr[1].ToString());
                        c = (dr[2].ToString());
                        d = (dr[3].ToString());
                        f = (dr[4].ToString());
                        g = (dr[5].ToString());
                        h = (dr[6].ToString());
                        i = (dr[7].ToString());
                        j = (dr[8].ToString());
                        k = (dr[9].ToString());
                        l = (dr[10].ToString());
                        m = (dr[11].ToString());
                        n = (dr[13].ToString());

                        if (username_all.Text == f && password_all.Text == g && active == n)
                        {
                            Console.WriteLine("here1");
                            MessageBox.Show("You are logged in!");
                            con.Close();
                            Student_Profile stdp = new Student_Profile(username_all.Text, a, b, c, d, k, f, g, h, i, j, l, m);
                            this.Hide();
                            stdp.Show();
                        }

                        /*else
                        {
                            Console.WriteLine("here3");
                            con.Close();
                        }*/
                        else if (username_all.Text == f && password_all.Text == g && active != n)
                        {
                            Console.WriteLine("here4");
                            con.Close();
                            MessageBox.Show("Your account is not activated yet..!");
                            clear();
                        }
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Wrong name or password..!");
                        clear();
                    }

                }
                else if (category == "librarian")
                {
                    con.Open();
                    String query = "SELECT * FROM librarian_tbl WHERE username = '" + username_all.Text.Trim() + "' AND password ='" + password_all.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        f = (dr[2].ToString());
                        Console.WriteLine(f);
                        g = (dr[3].ToString());
                        Console.WriteLine(g);

                        if (username_all.Text == f && password_all.Text == g)
                        {
                            Console.WriteLine("here1");
                            MessageBox.Show("You are logged in!");
                            Console.WriteLine("here2");
                            //this.Hide();
                            Hide();
                            L.Show();
                            Console.WriteLine("here now");
                            con.Close();
                        }

                        /*else
                        {
                            Console.WriteLine("here3");
                            con.Close();
                        }*/
                        /*else if (username_all.Text == f && password_all.Text == g)
                        {
                            Console.WriteLine("here4");
                            con.Close();
                            MessageBox.Show("Your account is not activated yet..!");
                            clear();
                        }*/
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Wrong name or password..!");
                        clear();
                    }

                }

                else if (category == "teacher")
                {
                    con.Open();
                    String query = "SELECT * FROM teacher_tbl WHERE username = '" + username_all.Text.Trim() + "' AND password ='" + password_all.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        f = (dr[3].ToString());
                        Console.WriteLine(f);
                        g = (dr[4].ToString());
                        Console.WriteLine(g);
                        a = (dr[6].ToString());
                        b = (dr[7].ToString());

                        if (username_all.Text == f && password_all.Text == g)
                        {
                            Console.WriteLine("here1");
                            MessageBox.Show("You are logged in!");
                            Console.WriteLine("here2");
                            //this.Hide();
                            TeacherProfile tp = new TeacherProfile(username_all.Text,a,b);
                            this.Hide();
                            tp.Show();
                            Console.WriteLine("here now");
                            con.Close();
                        }

                        /*else
                        {
                            Console.WriteLine("here3");
                            con.Close();
                        }*/
                        /*else if (username_all.Text == f && password_all.Text == g)
                        {
                            Console.WriteLine("here4");
                            con.Close();
                            MessageBox.Show("Your account is not activated yet..!");
                            clear();
                        }*/
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Wrong name or password..!");
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
        username_all.Text = "";
        password_all.Text = "";
        materialRadioButton1.Checked = false;
        materialRadioButton2.Checked = false;
        materialRadioButton3.Checked = false;
        materialRadioButton4.Checked = false;
    }

}
    
}
