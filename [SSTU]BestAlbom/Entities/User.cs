﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public byte[] Avatar { get; set; }
        public string MymeType { get; set; }
        //И еще какието данные. Сколь угодно много

        public User() { }
    }
}
