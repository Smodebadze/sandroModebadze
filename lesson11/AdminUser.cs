using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace lesson11
{
    internal class AdminUser : User
    {
        public AdminUser(string name, string mail)
        {
            FullName = name;
            Mail = mail;
        }

        public override string? ToString()
        {
            return $"you are the admin";
        }
    }
}
