using DAL;
using PROPS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class ProgramBAL
    {
        ProgramDAL program = new ProgramDAL();
        public DataTable GetProgram(Program p)
        {
            return (program.GetProgram(p));
        }
    }
}
