using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondServer
{
    public class User
    {
        //Standard properties (1)
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

        //Forigner Key properties (2)
        //public int RoleId { get; set; }
        //public int OccupationId { get; set; }

        //One-to-One connection for forigner keys (3)
        //public virtual Role Role { get; set; }
        //public virtual Occupation Occupation { get; set; }

    }
}
