﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab6.Models;

namespace Lab6.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StudentDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstName="Carson",LastName="Alexander",Program="ICT"},
            new Student{FirstName="Meredith",LastName="Alonso",Program="ICT"},
            new Student{FirstName="Arturo",LastName="Anand",Program="ICT"},
            new Student{FirstName="Gytis",LastName="Barzdukas",Program="ICT"},
            };
            foreach (Student c in students)
            {
                context.Students.Add(c);
            }
            context.SaveChanges();
        }
    }
}
