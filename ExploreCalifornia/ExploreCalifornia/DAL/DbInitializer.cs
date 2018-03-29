using System.Linq;
using ExploreCalifornia.Models;

namespace ExploreCalifornia.DAL
{
    public class DbInitializer
    {
        public static void Initialize(ExploreCaliforniaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Tours.Any())
            {
                return;
            }

            var tours = new Tours { };
            context.Tours.Add(tours);

            context.SaveChanges();
        }
    }

}