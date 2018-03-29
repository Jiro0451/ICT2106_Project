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
        public String LogType { get; set; }
        public DateTime Timestamp { get; set; }
        public int HouseholdID { get; set; }
        public String DeviceType { get; set; }
        public String Values { get; set; }

        public AppLog(String logType, DateTime timestamp, int householdID = 0, String deviceType = null, String values = null)
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

        public static AppLog FromJSON(string JSON)
        {
            var jObject = JObject.Parse(JSON);
            String newLogType = jObject["LogType"].ToString();
            DateTime newTimeStamp = DateTime.Parse(jObject["timeStamp"].ToString());
            String[] values = jObject["values"].ToString().Split(AppLogCreator.DELIMITER);
            int newHouseholdID = int.Parse(values[0]);
            String newDeviceType = null, newValues = null;
            if (values.Length == 2)
                newDeviceType = values[1];
            if (values.Length == 3)
                newValues = values[3];
            AppLog log = new AppLog(newLogType, newTimeStamp, newHouseholdID, newDeviceType, newValues);
            return log;
        }
    }
}
