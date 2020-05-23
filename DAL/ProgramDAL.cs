using PROPS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProgramDAL
    {
        DbCon db = new DbCon();

        public DataTable GetProgram(Program p)
        {
            string qry = "SELECT * FROM Program";
            DbCon db = new DbCon();
            DataTable dt;
            db.OpenCon();
            dt = db.Search(qry);
            db.CloseCon();
            return dt;
        }
    }
}
