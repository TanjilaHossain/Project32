using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS
{
    class Library_manageDTO
    {
        private String couno, bname, cname, wri, iid, rd;

        public Library_manageDTO(string couno, string bname, string cname, string wri, string iid, string rd)
        {
            this.iid = iid;
            this.couno = couno;
            this.bname = bname;
            this.wri = wri;
            this.cname = cname;
            this.rd = rd;
        }

        public string ID
        {
            get { return iid; }

            set { iid = value; }
        }

        public string COURSENO
        {
            get { return couno; }

            set { couno = value; }
        }

        public string BOOKNAME
        {
            get { return bname; }

            set { bname = value; }
        }

        public String WRITER
        {
            get { return wri; }

            set { wri = value; }
        }

        public String COURSENAME
        {
            get { return cname; }

            set { cname = value; }
        }

        public string RD
        {
            get { return rd; }

            set { rd = value; }
        }
    }
}
