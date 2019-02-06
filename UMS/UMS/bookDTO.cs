using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS
{
    class bookDTO
    {
        private int quan;
        private String couno, bname, cname, wri, iid;

        public bookDTO(string couno, string bname, string cname, int quan, string wri, string iid)
        {
            this.iid = iid;
            this.couno = couno;
            this.bname = bname;
            this.quan = quan;
            this.wri = wri;
            this.cname = cname;
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

        public int QUANTITY
        {
            get { return quan; }

            set { quan = value; }
        }

    }
}
