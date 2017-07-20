using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTX.Core.Interfaces;

namespace VTX.Core.Services
{
    class LogManager
    {
        public static ILogger GetLogger()
        {
            var stack = new StackTrace();
            var frame = stack.GetFrame(1);
            return new Log4NetWrapper(frame.GetMethod().DeclaringType);
        }
    }
}
