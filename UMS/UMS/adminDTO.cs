using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS
{
    class adminDTO
    {
        private String subject1, subject2, subject3, subject4, subject5, subject6, subject7, subject8, subject9, iid, th,sem;

        public adminDTO(string subject1, string subject2, string subject3, string subject4, string subject5, string subject6, string subject7, string subject8, string subject9, string iid, string th,string sem)
        {
            this.subject1 = subject1;
            this.subject2 = subject2;
            this.subject3 = subject3;
            this.subject4 = subject4;
            this.subject5 = subject5;
            this.subject6 = subject6;
            this.subject7 = subject7;
            this.subject8 = subject8;
            this.subject9 = subject9;
            this.th = th;
            this.iid = iid;
            this.sem = sem;
        }

        public string SEMESTER
        {
            get { return sem; }

            set { sem = value; }
        }

        public string SUBJECT1
        {
            get { return subject1; }

            set { subject1 = value; }
        }

        public string SUBJECT2
        {
            get { return subject2; }

            set { subject2 = value; }
        }

        public string SUBJECT3
        {
            get { return subject3; }

            set { subject3 = value; }
        }

        public string SUBJECT4
        {
            get { return subject4; }

            set { subject4 = value; }
        }

        public string SUBJECT5
        {
            get { return subject5; }

            set { subject5 = value; }
        }

        public string SUBJECT6
        {
            get { return subject6; }

            set { subject6 = value; }
        }

        public string SUBJECT7
        {
            get { return subject7; }

            set { subject7 = value; }
        }

        public string SUBJECT8
        {
            get { return subject8; }

            set { subject8 = value; }
        }

        public string SUBJECT9
        {
            get { return subject9; }

            set { subject9 = value; }
        }

        public string TH
        {
            get { return th; }

            set { th = value; }
        }

        public string ID
        {
            get { return iid; }

            set { iid = value; }
        }
    }
}
