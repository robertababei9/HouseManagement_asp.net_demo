using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HouseManagement.Models;

namespace HouseManagement.DAL
{
    public class DatabaseInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var persons = new List<Person>
            {
                new Person {FirstName = "Ababei", LastName = "Robert"},
                new Person {FirstName = "Ababei", LastName = "Razvan"},
                new Person {FirstName = "Amitroae", LastName = "Ciprian"},
            };

            persons.ForEach(s => context.Persons.Add(s));
            context.SaveChanges();

            var houses = new List<House>
            {
                new House {HouseName = "Iasi"},
                new House { HouseName = "Botosani"}
            };
            houses.ForEach(s => context.Houses.Add(s));
            context.SaveChanges();
        }
    }
}