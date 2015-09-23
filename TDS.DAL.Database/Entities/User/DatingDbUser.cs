using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDS.DAL.Database.Entities.User
{
    public class DatingDbUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        /// <summary>
        /// 0 = female
        /// 1 = male
        /// </summary>
        public int Gender { get; set; }
    }
}
