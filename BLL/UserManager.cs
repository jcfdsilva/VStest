
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class UserManager
    {
        public static float addQuotaByUID(string userUID, float quota)
        {
            return addQuotaByUsername(getUsernameByUID(userUID), quota);

        }

        public static string getUsernameByUID(string userUID)
        {
            return UserDB.getUsernameByUID(userUID);
        }
        public static float addQuotaByUsername(string userName, float quota)
        {
            quota = quota / 0.08f;
            int i = UserDB.addQuotaByUsername(userName, quota);

            if (i == 0)
                return -1;
            else
                return getQuotaByUser(userName);
        }

        public static float getQuotaByUID(String user)
        {
            return UserDB.getQuotaByUID(user);
        }

        public static float getQuotaByUser(String user)
        {
            return UserDB.getQuotaByUser(user);
        }

    }

}