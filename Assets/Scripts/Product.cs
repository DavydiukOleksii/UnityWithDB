﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace Assets.Scripts
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
