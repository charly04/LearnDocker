using System;
using System.Linq;
using LearnDocker.Data;
using LearnDocker.Data.Entities;

namespace LearnDocker.API
{
    public class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Candidates.Any())
            {
                return;   // DB has been seeded
            }

            var candidate = new Candidate()
            {
                ID = "1",
                Name = "Auto",
                Surname = "Generated",
                Address = "Yeah street",
                BirthDate = DateTime.UtcNow
            };
            context.Candidates.Add(candidate);
            context.SaveChanges();
        }
    }
}
