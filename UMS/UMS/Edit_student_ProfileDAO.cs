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
    class Edit_student_ProfileDAO
    {
        private String connectionString = @"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True";

        private SqlConnection con;

        private SqlCommand sqlCommand;

        private SqlDataAdapter sqlAdapter;

        private DataSet dataSet;

        public Edit_student_ProfileDAO()
        {
            con = new SqlConnection(connectionString);
        }

        public DataSet getstudentprofiles()
        {
            con.Open();

            String query = "select * from employee.employee";

            sqlCommand = new SqlCommand(query, con);

            sqlAdapter = new SqlDataAdapter();

            sqlAdapter.SelectCommand = sqlCommand;

            dataSet = new DataSet();

            sqlAdapter.Fill(dataSet);

            con.Close();

            return dataSet;
        }

        public void UpdateStudent(String firstname_lbl, String lastname_lbl, String id_lbl, String contact_lbl, String username_lbl, String password_txt, String address_lbl, String dept_lbl, String bldgrp_lbl)
        {
            con.Open();

            String query = "update student_tbl set first_name = '" + firstname_lbl + "' , last_name = '" + lastname_lbl + "' , mob = '" + contact_lbl + "',username = '" + username_lbl + "' , password = '" + password_txt + "' , address = '" + address_lbl + "', dept = '" + dept_lbl + "' , blood = '" + bldgrp_lbl + "',  where id = '" + id_lbl + "'";

            sqlCommand = new SqlCommand(query, con);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("data is update!");

            con.Close();
        }
    }
}
