using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROPS
{
    public class User
    {
        private int U_id;
        private String Name;
        private String Email;
        private String password;
        private int Campus_id;
        private int AccessLevel;
        private int Department_id;

        public int U_id1 { get => U_id; set => U_id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Password { get => password; set => password = value; }
        public int Campus_id1 { get => Campus_id; set => Campus_id = value; }
        public int AccessLevel1 { get => AccessLevel; set => AccessLevel = value; }
        public int Department_id1 { get => Department_id; set => Department_id = value; }
    }
}
