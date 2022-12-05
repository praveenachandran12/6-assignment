using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ASSIGNMENT6.BAL
{
    public class desBAL
    {
        DAL.desDAL objdeptdl = new DAL.desDAL();

        //create  variable based on the class
        private int deptid;
        private string depname;
        private int desid;
        private string designation;
        public int _deptid
        {
            get
            {
                return deptid;

            }
            set
            {
                deptid = value;
            }
        }

        public string _deptname
        {
            get
            {
                return depname;

            }
            set
            {
                depname = value;
            }
        }
        public int _desid
        {
            get
            {
                return desid;
            }
            set
            {
                desid = value;
            }
        }

        public string _designation
        {
            get
            {
                return designation;
            }
            set
            {
                designation = value;
            }
        }







        public DataTable getdept()
        {
            return objdeptdl.Getdept(this);
        }

        public int insertDesig()
        {
            return objdeptdl.Insertdesign(this);
        }
        public DataTable viewdesign()
        {
            return objdeptdl.desigview(this);
        }
        public int Desigupdate()
        {
            return objdeptdl.desgUpdate(this);
        }
        public int deletedesig()
        {
            return objdeptdl.Deletedesig(this);
        }
    }
}