using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Additional
{
    interface IAppLogRetriever
    {
        int aggregateQuery(ObjectId householdID, DateTime start, DateTime end, string logType = null, string deviceType = null);
        List<IAppLog> selectQuery(ObjectId householdID, DateTime start, DateTime end, string logType = null, string deviceType = null);
        List<string> listLogTypes(ObjectId householdID, DateTime start, DateTime end, string deviceType = null);
        List<string> listDeviceTypes(ObjectId householdID, DateTime start, DateTime end, string logType = null);
    }
}
