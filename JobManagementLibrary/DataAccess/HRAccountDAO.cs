using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementLibrary.DataAccess
{
    public class HRAccountDAO
    {
        private static HRAccountDAO instance = null;
        private static readonly object instanceLock = new object();
        public static HRAccountDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new HRAccountDAO();
                    }
                    return instance;
                }
            }
        }


        public bool HRLogin(string username, string password)
        {
            try
            {
                using var context = new JobManagementContext();
                var acc = context.Hraccounts.SingleOrDefault(hr => hr.Email == username.Trim() && hr.Password == password);
                if(acc != null && acc.MemberRole != 3)
                {
                    throw new Exception("You are not allowed to access");
                }

                return acc != null;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }

        }

    }
}
