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
        private List<AppLog> Buffer;
        public const string DELIMITER = "*/-";
        private const int MAX = 15;

        public AppLogCreator()
        {
            Buffer = new List<AppLog>();
            Console.WriteLine("New DataLogger created!");
        }

        public string GetCurrentType()
        {
            return this.GetType().ToString();
        }

        public void AddLog(Controller controller, string logType, DateTime timeStamp, string extras = null)
        {
            AppLog temp = new AppLog(controller.GetType().ToString() + DELIMITER + logType, timeStamp, 0); //PARSE IN HOUSEHOLD ID.
            Buffer.Add(temp);
            if (Buffer.Count == MAX) { //When Nth log is added
                pushLogs();
            }
            Console.WriteLine("Current buffer: ");
            Buffer.ForEach(Console.WriteLine);
        }

        private void pushLogs()
        {
            Console.WriteLine("Logs pushed to db");
            //CALL DATA LAYER METHOD
            Buffer.Clear(); //Clear buffer
        }
    }
}
