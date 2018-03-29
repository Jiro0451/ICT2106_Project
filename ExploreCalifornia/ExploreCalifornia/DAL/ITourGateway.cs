using ExploreCalifornia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.DAL
{
    interface ITourGateway
    {
        IEnumerable<Tours> SelectAll();
        Tours SelectById(int? id);
        void Insert(Tours tour);
        void Update(Tours tour);
        Tours Delete(int? id);
        void Save();
    }
}
