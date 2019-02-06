using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS
{
    class Edit_Student_ProfileDTO
    {
        private string firstname_lbl, lastname_lbl, id_lbl, contact_lbl, username_lbl, password_txt, address_lbl, dept_lbl, bldgrp_lbl;

        public Edit_Student_ProfileDTO(String firstname_lbl,String lastname_lbl,String id_lbl,String contact_lbl,String username_lbl,String password_txt,String address_lbl,String dept_lbl,String bldgrp_lbl)
        {
            this.firstname_lbl = firstname_lbl;
            this.lastname_lbl = lastname_lbl;
            this.id_lbl = id_lbl;
            this.contact_lbl = contact_lbl;
            this.username_lbl = username_lbl;
            this.password_txt = password_txt;
            this.address_lbl = address_lbl;
            this.dept_lbl = dept_lbl;
            this.bldgrp_lbl = bldgrp_lbl;
        }

        public String FIRSTNAME
        {
            get { return firstname_lbl; }

            set { firstname_lbl = value; }
        }
        public String LASTNAME
        {
            get { return lastname_lbl; }

            set { lastname_lbl = value; }
        }
        public String ID
        {
            get { return id_lbl; }

            set { id_lbl = value; }
        }
        public String CONTACT
        {
            get { return contact_lbl; }

            set { contact_lbl = value; }
        }
        public String USERNAME
        {
            get { return username_lbl; }

            set { username_lbl = value; }
        }
        public String PASS
        {
            get { return password_txt; }

            set { password_txt = value; }
        }
        public String ADDRESS
        {
            get { return address_lbl; }

            set { address_lbl = value; }
        }
        public String DEPT
        {
            get { return dept_lbl; }

            set { dept_lbl = value; }
        }
        public String BLD
        {
            get { return bldgrp_lbl; }

            set { bldgrp_lbl = value; }
        }
    }
}
