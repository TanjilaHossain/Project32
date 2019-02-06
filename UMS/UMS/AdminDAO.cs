using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS
{
    class AdminDAO
    {
        private String connectionString = @"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True";

        private SqlConnection sqlConnection;

        private SqlCommand sqlCommand;

        private SqlDataAdapter sqlAdapter;

        private DataSet dataSet;

        public AdminDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void approve_acnt(string iid)
        {
            sqlConnection.Open();

            String query = "update student_tbl set mark = 1 where id = '" + iid + "'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void delete_acnt(string iid)
        {
            sqlConnection.Open();

            String query = "delete from student_tbl where id = '" + iid + "'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void delete_teacher_acnt(string mb, string user)
        {
            sqlConnection.Open();

            String query = "delete from teacher_tbl where mob = '" + mb + "' and username = '"+ user +"'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void insert_result(adminDTO adDto)
        {
            sqlConnection.Open();

            String query = "insert into result (id,theory1,theory2,theory3,theory4,theory5,lab1,lab2,lab3,lab4,thesis,semester) values('" + adDto.ID + "','"
                                                              + adDto.SUBJECT1 + "','"
                                                              + adDto.SUBJECT2 + "','"
                                                              + adDto.SUBJECT3 + "','"
                                                              + adDto.SUBJECT4 + "','"
                                                              + adDto.SUBJECT5 + "','"
                                                              + adDto.SUBJECT6 + "','"
                                                              + adDto.SUBJECT7 + "','"
                                                              + adDto.SUBJECT8 + "','"
                                                              + adDto.SUBJECT9 + "','"
                                                              + adDto.TH + "','"
                                                              + adDto.SEMESTER + "')";

            sqlCommand = new SqlCommand(query, sqlConnection);



            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void update_result(string subject1, string subject2, string subject3, string subject4, string subject5, string subject6, string subject7, string subject8, string subject9, string iid, string th,string sem)
        {
            sqlConnection.Open();

            String query = "update result set theory1 = '"+ subject1 + "',theory2 = '" + subject2 + "',theory3 = '" + subject3 + "',theory4 = '" + subject4 + "',theory5 = '" + subject5 + "',lab1 = '" + subject6 + "',lab2 = '" + subject7 + "',lab3 = '" + subject8 + "',lab4 = '" + subject9 + "',thesis = '" + th + "',semester = '" + sem + "' where id = '" + iid + "'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
