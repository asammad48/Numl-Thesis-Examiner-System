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
    public class AuthBAL
    {
        public DataTable login(AuthPROPS ap)
        {
            return new AuthDAL().login(ap);
        }
    }
}
