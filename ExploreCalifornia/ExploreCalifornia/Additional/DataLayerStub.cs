using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExploreCalifornia.Additional
{
    public class DataLayerStub : IDataLayerStub
    {
        List<string> DATA;

        public DataLayerStub()
        {
            DATA = new List<string>();
            Console.WriteLine("New test db created!");
        }

        public void AddLog(string JSON)
        {
            DATA.Add(JSON);
        }

        public List<string> GetLogsQuery()
        {
            return DATA;
        }

        public int AggregateQuery()
        {
            return DATA.Count;
        }

        public List<string> GetUniqueTypesQuery(int type)
        {
            List<string> temp = new List<string>();
            temp.Add("Type1");
            temp.Add("Type2");
            return temp;
        }
    }
}
