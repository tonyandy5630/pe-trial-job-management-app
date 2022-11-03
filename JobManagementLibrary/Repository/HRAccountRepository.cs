using JobManagementLibrary.DataAccess;
using JobManagementLibrary.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementLibrary.Repository
{
    public class HRAccountRepository:IHRAccountRepository
    {
        public bool HRLogin(string username, string password) => HRAccountDAO.Instance.HRLogin(username, password);
    }
}
