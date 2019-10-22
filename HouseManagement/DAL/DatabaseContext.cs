using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using HouseManagement.Models;
using System.Linq;
using System.Web;

namespace HouseManagement.DAL
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(): base("DatabaseContext")
        {

        }

        public DbSet<House> Houses { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}