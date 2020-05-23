using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPS
{
    public class ExaminerProps
    {
        private int E_id;
        private String E_Name;
        private String Inst_addrs;
        private int E_type;
        private int D_id;
        private int Status;

        public int E_id1 { get => E_id; set => E_id = value; }
        public string E_Name1 { get => E_Name; set => E_Name = value; }
        public string Inst_addrs1 { get => Inst_addrs; set => Inst_addrs = value; }
        public int E_type1 { get => E_type; set => E_type = value; }
        public int D_id1 { get => D_id; set => D_id = value; }
        public int Status1 { get => Status; set => Status = value; }
    }
}
