﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Database
{
    class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DbConnection")
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
