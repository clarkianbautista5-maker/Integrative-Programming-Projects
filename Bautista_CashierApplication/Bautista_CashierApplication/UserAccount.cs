using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string uName, string password)
        {
            full_name = name;
            user_name = uName;
            user_password = password;
        }

        public virtual bool validateLogin(string uName, string password)
        {
            return user_name == uName && user_password == password;
        }

        public string getFullName() => full_name;
    }

    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string uName, string password)
            : base(name, uName, password)
        {
            this.department = department;
        }

        public override bool validateLogin(string uName, string password)
        {
            return base.validateLogin(uName, password);
        }

        public string getDepartment() => department;
    }
}