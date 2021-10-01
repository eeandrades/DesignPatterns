using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Logger
{
    public static class LoggerWriterExtensions
    {
        public static LogBuilder Start(this ILoggerWriter logWriter)
        {
            return new LogBuilder(logWriter);
        }

        public static void WriteLog(this ILoggerWriter logWriter, Func<LogBuilder, LogBuilder> function)
        {
            function.Invoke(logWriter.Start())
                .Finish();
        }
    }
}
