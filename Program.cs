﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_4_
{
    class User
    {
        public string login = "QWERTY";
        public string name = "Denis";
        public string surname = "Daninko";
        public int age = 18;
        public readonly DateTime date = DateTime.Now;


        public User(string loginx, string namex, string surnamex, int agex)
        {
            loginx = login;
            namex = name;
            surnamex = surname;
            agex = age;
        }

    }
}