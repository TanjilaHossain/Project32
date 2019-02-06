using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS
{
    class Library_manageDAO
    {
        private String connectionString = @"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True";

        private SqlConnection sqlConnection;

        private SqlCommand sqlCommand;

        private SqlDataAdapter sqlAdapter;

        private DataSet dataSet;

        public Library_manageDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void issuebook(Library_manageDTO lDTO)
        {
            sqlConnection.Open();

            String query = "insert into issue_books (COURSENO,BOOKNAME,COURSENAME,WRITER,ID,RETURN_DATE) values('" + lDTO.COURSENO + "','"
                                                              + lDTO.BOOKNAME + "','"
                                                              + lDTO.COURSENAME + "','"
                                                              + lDTO.WRITER + "','"
                                                              + lDTO.ID + "','"
                                                              + lDTO.RD + "')";

            sqlCommand = new SqlCommand(query, sqlConnection);



            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void request_delete(string iid)
        {
            sqlConnection.Open();

            String query = "delete from bookrequest where ID = '" + iid + "'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
