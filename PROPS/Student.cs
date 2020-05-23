using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPS
{
    public class Student
    {
        private int St_id;
        private String Name;
        private String Regno;

        private int P_id;
        private String Supervisor;
        private String Co_Supervisor;

        private String Hod_Status;
        private String Hod_Remark;
        private String Hod_Date;

        private String Dean_Status;
        private String Dean_Remark;
        private String Dean_Date;

        private String Dir_acad_Status;
        private String Dir_acad_Remark;
        private String Dir_acad_Date;

        private String DG_Status;
        private String DG_Remark;
        private String DG_Date;

        private String Rector_Status;
        private String Rector_Remark;
        private String Rector_Date;


        private int type;

        public int St_id1 { get => St_id; set => St_id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Regno1 { get => Regno; set => Regno = value; }
        public int P_id1 { get => P_id; set => P_id = value; }
        public string Supervisor1 { get => Supervisor; set => Supervisor = value; }
        public string Co_Supervisor1 { get => Co_Supervisor; set => Co_Supervisor = value; }
        public string Hod_Status1 { get => Hod_Status; set => Hod_Status = value; }
        public string Hod_Remark1 { get => Hod_Remark; set => Hod_Remark = value; }
        public string Hod_Date1 { get => Hod_Date; set => Hod_Date = value; }
        public string Dean_Status1 { get => Dean_Status; set => Dean_Status = value; }
        public string Dean_Remark1 { get => Dean_Remark; set => Dean_Remark = value; }
        public string Dean_Date1 { get => Dean_Date; set => Dean_Date = value; }
        public string Dir_acad_Status1 { get => Dir_acad_Status; set => Dir_acad_Status = value; }
        public string Dir_acad_Remark1 { get => Dir_acad_Remark; set => Dir_acad_Remark = value; }
        public string Dir_acad_Date1 { get => Dir_acad_Date; set => Dir_acad_Date = value; }
        public string DG_Status1 { get => DG_Status; set => DG_Status = value; }
        public string DG_Remark1 { get => DG_Remark; set => DG_Remark = value; }
        public string DG_Date1 { get => DG_Date; set => DG_Date = value; }
        public string Rector_Status1 { get => Rector_Status; set => Rector_Status = value; }
        public string Rector_Remark1 { get => Rector_Remark; set => Rector_Remark = value; }
        public string Rector_Date1 { get => Rector_Date; set => Rector_Date = value; }
        public int Type { get => type; set => type = value; }
    }
}
