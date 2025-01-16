using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DatabaseAccess;

namespace BusinessLogic
{
    public class UserBL
    {
        public CustomBO AddUser(UserBO userBO)
        {
            return new UserDAL().AddUser(userBO);
        }
    }
}
