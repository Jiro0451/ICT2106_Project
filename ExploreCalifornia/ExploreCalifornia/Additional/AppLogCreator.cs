using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Additional
{
    public class AppLogCreator : IAppLogCreator
    {
        List<string> Buffer;
        public const string DELIMITER = "*/-";
        DataLayerStub dbs;

        public AppLogCreator(IDataLayerStub dataLayerStub)
        {
            dbs = (DataLayerStub) dataLayerStub;
            Buffer = new List<string>();
            Console.WriteLine("New DataLogger created!");
        }

        public string GetCurrentType()
        {
            return this.GetType().ToString();
        }

        public void AddLog(Controller controller, string logType, DateTime timeStamp, string extras = null)
        {
            AppLog temp = new AppLog(controller.GetType().ToString() + DELIMITER + logType, timeStamp);
            string json = JsonConvert.SerializeObject(temp, Formatting.Indented);
            Buffer.Add(json);
            if (Buffer.Count == 10) { //When 10th log is added
                pushLogs();
            }
            Console.WriteLine("Current buffer: ");
            Buffer.ForEach(Console.WriteLine);
        }

        private void pushLogs()
        {
            Console.WriteLine("Logs pushed to db");
            Buffer.ForEach(dbs.AddLog);
            Buffer.Clear(); //Clear buffer
        }
    }
}
