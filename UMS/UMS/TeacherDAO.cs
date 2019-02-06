using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMS
{
    class TeacherDAO
    {
        private String connectionString = @"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True";

        //SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-6VBFHVH\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
        private SqlConnection sqlConnection;

        private SqlCommand sqlCommand;

        private SqlDataAdapter sqlDataAdapter;
        //DataTable dt;
        private DataSet ds = new DataSet();

        public TeacherDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void RegisterTeacher(TeacherDTO teacherDto)
        {
            sqlConnection.Open();

            String query = "insert into teacher_tbl(first_name, last_name, mob, username, password, address, designation,department, blood, gender,image) values('"
                                                          + teacherDto.FIRSTNAME + "','"
                                                          + teacherDto.LASTNAME + "','"
                                                          + teacherDto.MOB + "','"
                                                          + teacherDto.USERNAME + "','"
                                                          + teacherDto.PASSWORD + "','"
                                                          + teacherDto.ADDRESS + "','"
                                                          + teacherDto.DESIGNATION + "','"
                                                          + teacherDto.DEPARTMENT + "','"
                                                          + teacherDto.BLOOD + "','"
                                                          + teacherDto.GENDER + "',@img)";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.Add(new SqlParameter("@img", teacherDto.IMAGE));
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Account has created successfully!");
            sqlConnection.Close();

        }



        //checking muliple username
        public Boolean CheckTeacherExistance(TeacherDTO teacherDto)
        {

            sqlConnection.Open();
            //TeacherDTO teacherDto = new TeacherDTO(t_id.Text, t_firstname.Text, t_lastname.Text, t_mobnum.Text, t_username.Text, t_pass.Text, t_address.Text, t_designation.Text, t_bldgrp.Text, gender, img);
            String query = "select * from teacher_tbl where username='" + teacherDto.USERNAME + "'";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(ds);
            sqlConnection.Close();
            int count = ds.Tables[0].Rows.Count;

            if (count > 0)
            {
                return true;
            }

            return false;

        }
    }
}
