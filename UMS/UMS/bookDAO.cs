using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS
{
    class bookDAO
    {
        private String connectionString = @"Data Source=SAJID-THINKPAD\SQLEXPRESS;Initial Catalog=UMS;Integrated Security=True";

        private SqlConnection sqlConnection;

        private SqlCommand sqlCommand;

        private SqlDataAdapter sqlAdapter;

        private DataSet dataSet;

        public bookDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void requestbook(bookDTO bDto)
        {
            sqlConnection.Open();

            String query = "insert into bookrequest (COURSENO,BOOKNAME,COURSENAME,WRITER,ID) values('" + bDto.COURSENO + "','"
                                                              + bDto.BOOKNAME + "','"
                                                              + bDto.COURSENAME + "','"
                                                              + bDto.WRITER + "','"
                                                              + bDto.ID + "')";

            sqlCommand = new SqlCommand(query, sqlConnection);



            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }


        public void insertbook(bookDTO bDto)
        {
            sqlConnection.Open();

            String query = "insert into books (courseno,bookname,coursename,quantity,writer) values('" + bDto.COURSENO + "','"
                                                              + bDto.BOOKNAME + "','"
                                                              + bDto.COURSENAME + "','"
                                                              + bDto.QUANTITY + "','"
                                                              + bDto.WRITER + "')";

            sqlCommand = new SqlCommand(query, sqlConnection);



            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void updatequantity(int quan, string bname)
        {
            sqlConnection.Open();

            String query = "update books set quantity = '" + quan + "' where bookname = '" + bname + "'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }


        public void ret_update_book(string bname, int quan)
        {
            sqlConnection.Open();

            String query = "update books set quantity = '" + quan + "' where bookname = '" + bname + "'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }


        public void L_update_book(string couno, string bname, string cname, int quan, string wri, string iid)
        {
            sqlConnection.Open();

            String query = "update books set bookname = '" + bname + "', coursename = '" + cname + "', quantity = '" + quan + "', writer = '" + wri + "' where courseno = '" + couno + "'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }


        public void L_delete_book(string bname)
        {
            sqlConnection.Open();

            String query = "delete from books where bookname = '" + bname + "'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }


        public void delete_issue_book(string iid)
        {
            sqlConnection.Open();

            String query = "delete from issue_books where ID = '" + iid + "'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void deletebook(string bname)
        {
            sqlConnection.Open();

            String query = "delete from books where bookname = '" + bname + "'";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
