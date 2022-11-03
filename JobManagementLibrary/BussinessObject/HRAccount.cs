using System;
using System.Collections.Generic;

namespace JobManagementLibrary.DataAccess
{
    public partial class Hraccount
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Fullname { get; set; } = null!;
        public int MemberRole { get; set; }
    }
}
