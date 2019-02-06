using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace UMS
{
    public partial class TeacherProfile : MaterialSkin.Controls.MaterialForm
    {
        String t_username, t_dp, t_dg;

        public TeacherProfile(String datas, String dept, String designation)
        {
            InitializeComponent();
            t_username = datas;
            t_dg = designation;
            t_dp = dept;
            picshow();
            t_name.Text = t_username;
            t_dept.Text = t_dp;
            t_designation.Text = t_dg;
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void t_submit_result_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ope = new OpenFileDialog();
                ope.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm*";
                if (ope.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                FileStream stream = new FileStream(ope.FileName, FileMode.Open);
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                DataSet result = excelReader.AsDataSet();

                DataClasses1DataContext conn = new DataClasses1DataContext();
                foreach (DataTable table in result.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                        marks_tbl addtable = new marks_tbl()
                        {
                            student_id = Convert.ToString(dr[0]),
                            quiz = Convert.ToInt32(dr[1]),
                            class_performance = Convert.ToInt32(dr[2]),
                            final = Convert.ToInt32(dr[3]),
                            total = Convert.ToInt32(dr[4]),
                            grade = Convert.ToString(dr[5]),
                        };
                        conn.marks_tbls.InsertOnSubmit(addtable);

                    }
                }
                //String stringconn = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox1.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";
                conn.SubmitChanges();
                excelReader.Close();
                stream.Close();
                MessageBox.Show("successfull");
            }
            catch (Exception ex)
            {
                //sqlConnection.Close();
                MessageBox.Show("This file is already in the database!");
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True");
        DataTable dt = new DataTable();

        private void back_Click(object sender, EventArgs e)
        {
            LogIn lg = new LogIn();
            MessageBox.Show("Do you really want to sign out?");
            this.Hide();
            lg.Show();
        }

        //TeacherDTO teacherDto = new TeacherDTO();
        TeacherRegistration tr = new TeacherRegistration();
        public void picshow()
        {
            try
            {
                string sql = "SELECT image FROM teacher_tbl WHERE username = '" + t_username + "'";
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
                            picture_teacher.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            picture_teacher.Image = Image.FromStream(ms);
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
    }
}
