using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Channels;

namespace lesson11
{
    internal abstract class User
    {
        public String FullName { get; set; }
        public String Mail { get; set; }

       
    }
}
