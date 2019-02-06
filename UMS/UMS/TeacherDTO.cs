using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS
{
    class TeacherDTO
    {
        private String first_name, last_name, mob, username, password, address, designation, blood, gender, dept;
        byte[] img = null;

        public TeacherDTO(String first_name, String last_name, String mob, String username, String password, String address, String designation, String dept, String blood, String gender, byte[] img)
        {
            this.dept = dept;
            this.first_name = first_name;
            this.last_name = last_name;
            this.mob = mob;
            this.username = username;
            this.password = password;
            this.address = address;
            this.designation = designation;
            this.blood = blood;
            this.gender = gender;
            this.img = img;

        }

        public String DEPARTMENT
        {
            get { return dept; }

            set { dept = value; }
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
        public String MOB
        {
            get { return mob; }

            set { mob = value; }
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
        public String ADDRESS
        {
            get { return address; }

            set { address = value; }
        }
        public String DESIGNATION
        {
            get { return designation; }

            set { designation = value; }
        }
        public String BLOOD
        {
            get { return blood; }

            set { blood = value; }
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
