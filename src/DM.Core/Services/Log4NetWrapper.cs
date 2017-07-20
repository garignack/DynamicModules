using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTX.Core.Interfaces;

namespace VTX.Core.Services
{
    class Log4NetWrapper : ILogger
    {
        private readonly log4net.ILog _logger;

        public Log4NetWrapper(Type type)
        {
            _logger = log4net.LogManager.GetLogger(type);
        }

        public void Debug(object message)
        {
            _logger.Debug(message);
        }

        public bool IsDebugEnabled
        {
            get { return _logger.IsDebugEnabled; }
        }
        public void Info(object message)
        {
            _logger.Debug(message);
        }

        public bool IsInfoEnabled
        {
            get { return _logger.IsDebugEnabled; }
        }
        public void Error(object message)
        {
            _logger.Debug(message);
        }

        public bool IsErrorEnabled
        {
            get { return _logger.IsDebugEnabled; }
        }
        public void Warn(object message)
        {
            _logger.Debug(message);
        }

        public bool IsWarnEnabled
        {
            get { return _logger.IsDebugEnabled; }
        }
        public void Fatal(object message)
        {
            _logger.Debug(message);
        }

        public bool IsFatalEnabled
        {
            get { return _logger.IsDebugEnabled; }
        }
    }
}
