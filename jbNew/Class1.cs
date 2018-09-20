using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jbNew
{
    public class Class1
    {
        public string ctdb(string s)
        {
            string a = "'";
            string b = s;
            b = a + b;
            b = b + a;
            return b;
        }
    }
}