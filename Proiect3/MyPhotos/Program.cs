using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(Model1Container context = new Model1Container())
            {
                File file = new File()
                {
                    Id = Guid.NewGuid(),
                    Name = "MyFirstFile",
                    Path = "TBD"
                };

                context.Files.Add(file);
                context.SaveChanges();
            }
        }
    }
}
