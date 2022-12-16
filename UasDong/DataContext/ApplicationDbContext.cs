using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using UasDong.Models;

namespace UasDong.DataContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base(nameOrConnectionString:"Myconnection")
        {
            
        
        }

        public virtual DbSet<EmpClass> Empobj { get; set; }

    }

}