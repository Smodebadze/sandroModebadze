using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace lesson11
{
    internal class ClientUser : User
    {
        public ClientUser(string name, string mail)
        {
            FullName = name;
            Mail = mail;
        }

        public override string? ToString()
        {
            return $"you are just an ordinary user";
        }
    }
}
