using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTX.Core.Interfaces
{
    public interface ILogger
    {
        void Debug(object message);
        bool IsDebugEnabled { get; }
        void Info(object message);
        bool IsInfoEnabled { get; }
        void Warn(object message);
        bool IsWarnEnabled { get; }
        void Error(object message);
        bool IsErrorEnabled { get; }
        void Fatal(object message);
        bool IsFatalEnabled { get; }
    }
}
