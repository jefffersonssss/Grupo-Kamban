﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using SQLite;


namespace Login.Model
{
    [Table("user")]

    public class User
    {
        [PrimaryKey, AutoIncrement]


        public int Id { get; set; }
        [MaxLength(100), Unique]
        public String Username { get; set; }
        [MaxLength(100), Unique]
        public String Email { get; set; }
        [MaxLength(70)]
        public String Password { get; set; }

    }
}
