using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
        public User()
        {
            Languages = new List<string>();
        }

    }
}
