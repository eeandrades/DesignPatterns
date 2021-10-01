using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Logger
{
    public interface ILoggerWriter
    {
        void WriteLog(int level, string message, object data, object context, Exception exception);


    }

    public record Log
    {
        public int Level { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public object Context { get; set; }
        public Exception Exception { get; set; }

    }
}
