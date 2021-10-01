using DesignPatterns.Logger;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Logger
{
    [TestClass]
    public class Test
    {
        public class LoggerWriterMock : ILoggerWriter
        {
            void ILoggerWriter.WriteLog(int level, string message, object data, object context, Exception exception)
            {
                Console.WriteLine($"Level: {level}");
                Console.WriteLine($"Message: {message}");
                Console.WriteLine($"Data: {data?.ToString()}");
                Console.WriteLine($"Context: {context?.ToString()}");
                Console.WriteLine($"Exception: {exception?.ToString()}");
            }
        }



        [TestMethod]
        public void Execute()
        {
            var logger = new LoggerWriterMock();
            //normal
            logger
                .Start()
                .WithMessage("Mensagem final processamento")
                .WithContext(new { Total = 20, Erros = 5, Sucesso = 15 })
                .WithLevel(2)
                .Finish();

            //exception
            try
            {
                throw new ApplicationException("Erro simulado");
            }
            catch (Exception ex)
            {
                logger
                    .Start()
                    .WithMessage("Exception Message")
                    .WithContext(new { Total = 20, Erros = 5, Sucesso = 15 })
                    .WithException(ex)
                    .WithLevel(5)
                    .Finish();
            }

            //evita esquecer o finish
            logger.WriteLog(lb => lb
                    .WithMessage("Evita esquecer o finish")
                    .WithContext(new { Total = 20, Erros = 5, Sucesso = 15 })
                    .WithLevel(2));


        }
    }
}
