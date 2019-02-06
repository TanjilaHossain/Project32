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
    class LibrarianDAO
    {
        private String connectionString = @"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True";

        private SqlConnection sqlConnection;

        private SqlCommand sqlCommand;

        private SqlDataAdapter sqlDataAdapter;
        //DataTable dt;
        private DataSet ds = new DataSet();

        public LibrarianDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void RegisterLibrarian(LibrarianDTO librarianDto)
        {
            sqlConnection.Open();

            String query = "insert into librarian_tbl (first_name,last_name,username,password,gender,image) values('"
                                                          + librarianDto.FIRSTNAME + "','"
                                                          + librarianDto.LASTNAME + "','"
                                                          + librarianDto.USERNAME + "','"
                                                          + librarianDto.PASSWORD + "','"
                                                          + librarianDto.GENDER + "',@img)";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.Parameters.Add(new SqlParameter("@img", librarianDto.IMAGE));
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Account has created successfully!");
            sqlConnection.Close();

        }



        //checking muliple username
        public Boolean CheckLibrarianExistance(LibrarianDTO librarianDto)
        {

            sqlConnection.Open();
            //TeacherDTO teacherDto = new TeacherDTO(t_id.Text, t_firstname.Text, t_lastname.Text, t_mobnum.Text, t_username.Text, t_pass.Text, t_address.Text, t_designation.Text, t_bldgrp.Text, gender, img);
            String query = "select * from librarian_tbl where username='" + librarianDto.USERNAME + "'";
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
