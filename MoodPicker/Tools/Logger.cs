using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodPicker.Tools
{
    abstract class Logger
    {
        static public void Log(string message) {
            #if DEBUG
            Console.WriteLine(DateTime.Now.ToLongTimeString() + " " + message);
            #endif
        }

    }
}
