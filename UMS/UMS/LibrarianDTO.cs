using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS
{
    class LibrarianDTO
    {
        private String first_name, last_name, username, password, gender;
        byte[] img = null;

        public LibrarianDTO(String first_name, String last_name, String username, String password, String gender, byte[] img)
        {

            this.first_name = first_name;
            this.last_name = last_name;
            this.username = username;
            this.password = password;
            this.gender = gender;
            this.img = img;

        }


        public String FIRSTNAME
        {
            get { return first_name; }

            set { first_name = value; }
        }
        public String LASTNAME
        {
            get { return last_name; }

            set { last_name = value; }
        }

        public String USERNAME
        {
            get { return username; }

            set { username = value; }
        }
        public String PASSWORD
        {
            get { return password; }

            set { password = value; }
        }

        public String GENDER
        {
            get { return gender; }

            set { gender = value; }
        }
        public byte[] IMAGE
        {
            get { return img; }

            set { img = value; }
        }
    }
}
