using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    public abstract class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            this.user_id = id;
            this.user_password = pass;
        }

        public string GetUserId()
        {
            return user_id;
        }

        public abstract bool verifyLogin(string id, string pass);

        public void updatePassword(string newPassword)
        {
            this.user_password = newPassword;
        }
    }
}