using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;

namespace ExploreCalifornia.DAL
{
    public class TourGateway : ITourGateway
    {
        internal ExploreCaliforniaContext db = new ExploreCaliforniaContext();

        public Tours Delete(int? id)
        {
            Tours tour = db.Tours.Find(id);
            db.Tours.Remove(tour);
            Save();

            return tour;
        }

        public void Insert(Tours tour)
        {
            db.Tours.Add(tour);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Tours> SelectAll()
        {
            List<Tours> tour = db.Tours.ToList();
            return tour;
        }

        public Tours SelectById(int? id)
        {
            return db.Tours.Find(id);
        }

        public void Update(Tours tour)
        {
            db.Tours.Update(tour);
            Save();
        }
    }
}
