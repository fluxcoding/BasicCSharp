﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Klasi
{
    class User
    {

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string[] Messages { get; set; }




        public User(int id, string username, string password, string[] messages)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = messages;
        }

    }
}
