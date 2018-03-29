using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Additional
//namespace SmartHome.Models
{
    public class AppLog : IAppLog
    {
        private String LogType { get; set; }
        private DateTime Timestamp { get; set; }
        private ObjectId HouseholdID { get; set; }
        private String DeviceType { get; set; }
        private String Values { get; set; }

        public AppLog(String logType, DateTime timestamp, ObjectId householdID, String deviceType = null, String values = null)
        {
            LogType = logType;
            Timestamp = timestamp;
            HouseholdID = householdID;
            DeviceType = deviceType;
            Values = values;
        }

        public String ToAppLogString()
        {
            return "AppLog: " + LogType + ", " + Timestamp.ToString() + ", " + HouseholdID + ", " + DeviceType + ", " + Values;
        }
    }
}
