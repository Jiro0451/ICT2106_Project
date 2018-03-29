using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Additional
{
    public interface IAppLogCreator
    {
        string GetCurrentType();
        void AddLog(Controller controller, string logType, DateTime timeStamp, string extras = null);
    }
}
