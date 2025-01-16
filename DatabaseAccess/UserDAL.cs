using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DatabaseAccess
{
    public class UserDAL
    {
        private UserDBEntities userDBEntities;

        public UserDAL()
        {
            userDBEntities = new UserDBEntities();
        }

        public CustomBO AddUser(UserBO userBO)
        {
            CustomBO customBO = new CustomBO();
            User user = new User()
            {
                user_name = userBO.userName,
                user_address = userBO.userAddress,
                user_email = userBO.userEmail,
                user_mobile = userBO.userMobile,
            };
            userDBEntities.Users.Add(user);
            int returnValue = userDBEntities.SaveChanges();

            if (returnValue > 0)
            {
                customBO.customMessage = "Data Successfully added.";
            }
            else
            {
                customBO.customMessage = "Error occured while adding the user.";
            }
            customBO.customNumber = returnValue;
            return customBO;
        }
    }
}
