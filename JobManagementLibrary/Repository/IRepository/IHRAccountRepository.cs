using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementLibrary.Repository.IRepository
{
    public interface IHRAccountRepository
    {
        bool HRLogin(string username, string password);
    }
}
