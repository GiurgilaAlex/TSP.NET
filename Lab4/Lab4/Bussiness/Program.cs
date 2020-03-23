using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4.Bussiness
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddItems();
            foreach(var item in GetItems().ToList())
            {
                Console.WriteLine(item);
            }
        }

        private static void AddItems()
        {
            using (ModelContext context = new ModelContext())
            {
                Property p = new Property()
                {
                    Id = Guid.NewGuid(),
                    Key = "Location",
                    Value = "Constanta",
                    FileId = Guid.Parse("240f4c2b-50ae-492f-9d71-08928257f64e")
                };

                File f = new File()
                {
                    Id = Guid.Parse("240f4c2b-50ae-492f-9d71-08928257f64e"),
                    Name = "MyFirstPicture",
                    Path = "FirstPath"
                };

                context.Files.Add(f);
                context.Properties.Add(p);
                context.SaveChanges();
            }
        }

        private static IQueryable<File> GetItems()
        {
            using (ModelContext context = new ModelContext()) 
            {
                return context.Set<File>();
            }

        }
    }
}
