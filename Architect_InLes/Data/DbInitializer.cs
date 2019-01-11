using BusinessFacade;
using Data;
using System.Linq;

namespace Architect_InLes.Data
{
    public class DbInitializer
    {
        public static void Initialize(ArchitectDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any movies
            if (context.Customers.Any())
            {
                return;
            }

            context.Customers.AddRange(
                new Customer{ FirstName = "Kurt", LastName = "Van de gaer" },
                new Customer{ FirstName = "Erik", LastName = "Kaes" },
                new Customer{ FirstName = "Philippe", LastName = "Kenens" },
                new Customer{ FirstName = "Petra", LastName = "Luyten" }
                );

            context.SaveChanges();
        }
    }
}
