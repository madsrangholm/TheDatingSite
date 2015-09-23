using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TDS.BLL.User
{
    public class DatingUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public Sexuality Sexuality { get; set; }
        public Gender Gender { get; set; }
        public MailAddress Email { get; set; } 

    }
}
