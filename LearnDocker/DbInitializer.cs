﻿using System;
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

            var candidate1 = new Candidate()
            {
                Name = "Auto",
                Surname = "Generated",
                Address = "Yeah street",
                BirthDate = DateTime.UtcNow
            };
            var candidate2 = new Candidate()
            {
                Name = "Auto2",
                Surname = "Generated2",
                Address = "Yeah street2",
                BirthDate = DateTime.UtcNow
            };
            context.Candidates.Add(candidate1);
            context.Candidates.Add(candidate2);
            context.SaveChanges();
        }
    }
}
