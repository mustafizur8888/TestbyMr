﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model
{
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext()
            : base("DefaultConnection")
        {
             
        }
        public DbSet<Phone> Phones { get; set; } 
    }
}
