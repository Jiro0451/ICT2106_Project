using System.Collections.Generic;

namespace ExploreCalifornia.Additional
{
    public interface IDataLayerStub
    {
        //Adding
        void AddLog(string JSON);

        //Retrieving
        List<string> GetLogsQuery();
        int AggregateQuery();
        List<string> GetUniqueTypesQuery(int type);
    }
}