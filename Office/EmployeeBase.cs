using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    public class EmployeeBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int status { get; set; }
        public string role { get; set; }
        public DateTime? createdDate { get; set; } = null;
        public DateTime? updateDate { get; set; } = null;
        public DateTime? DeleteDate { get; set; } = null;
    }
}
