using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST_PrintPayment_G3.Models
{
    public class User
    {
        public string Uid { get; set; }
        public string Username { get; set; }
        public float Credit { get; set; }

        public User(string uid, string username, float credit)
        {
            Uid = uid;
            Username = username;
            Credit = credit;
        }
    }
}