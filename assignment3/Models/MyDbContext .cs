using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using HOL_3.Models;

namespace HOL_3.Model
 {
    public class MyDbContext : System.Data.Entity.DbContext
    {
        public MyDbContext()
        : base("name=conn")
        {



        }
        public System.Data.Entity.DbSet<User> Users { get; set; }
    }
}