using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Additional
{
    public class AppLogRetriever : IAppLogRetriever
    {
        public int aggregateQuery(DateTime start, DateTime end, string logType = null, string deviceType = null)
        {
            return //Ernest method with household ID
        }

        public List<string> listDeviceTypes(DateTime start, DateTime end, string logType = null)
        {
            return //Ernest method with household ID
        }

        public List<string> listLogTypes(DateTime start, DateTime end, string deviceType = null)
        {
            return //Ernest method with household ID
        }

        public List<IAppLog> selectQuery(DateTime start, DateTime end, string logType = null, string deviceType = null)
        {
            return //Ernest method with household ID
        }
    }
}
