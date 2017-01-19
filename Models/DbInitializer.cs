using SampleEFCoreMigration.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleEFCoreMigration.Models
{
    public class DbInitializer
    {
        public static void Initialize(SampleEFCoreMigrationContext context)
        {
            // Checks to see if the Db exists, if not it creates it.
            context.Database.EnsureCreated();

            // Looks to see if any Chemicals are in the Db, if so, the Db is already there
            //  and seeded therefore doesn't need any seeding.
            if (context.Chemicals.Any())
            {
                return;   // DB has been seeded
            }

            // If there is no Chemicals found in the Db, these get "Seeded" into the Db
            Chemical tempChemical1 = new Chemical()
            {
                Name = "Benzene",
                Opened = DateTime.Now
            };

            Chemical tempChemical2 = new Chemical()
            {
                Name = "Acetone",
                Opened = new DateTime(2014, 04, 20)
            };

            Chemical tempChemical3 = new Chemical()
            {
                Name = "Water",
                Opened = new DateTime(2015, 03, 11)
            };

            context.Chemicals.Add(tempChemical1);
            context.Chemicals.Add(tempChemical2);
            context.Chemicals.Add(tempChemical3);

            context.SaveChanges();
        }
    }
}
