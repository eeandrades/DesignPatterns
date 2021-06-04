using DesignPatterns.Decorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatternsTest.Decorator
{
    [TestClass]

    public class Test
    {
        [TestMethod]
        public void PaoFrancesComPresuntoEQueijo()
        {
            var paoFrances = new PaoFrances();

            var paoComQueijo = new RecheioQueijo(paoFrances);
            var paoComQueijoPresunto = new RecheioPresunto(paoComQueijo);

            Assert.IsTrue(paoFrances.Valor == 2);
            Assert.IsTrue(paoComQueijo.Valor == 5);
            Assert.IsTrue(paoComQueijoPresunto.Valor == 9);

            Console.WriteLine($"{paoFrances.Nome} = {paoFrances.Valor}");
            Console.WriteLine($"{paoComQueijo.Nome} = {paoComQueijo.Valor}");
            Console.WriteLine($"{paoComQueijoPresunto.Nome} = {paoComQueijoPresunto.Valor}");
        }

        [TestMethod]
        public void PaoFrancesComPresuntoEQueijoUsandoExtensions()
        {
            var paoFrances = new PaoFrances();


            var paoComManteiga = paoFrances.PassarManteiga();
            var paoComQueijo = paoComManteiga.RechearComQueijo();
            var paoComQueijoPresunto = paoComQueijo.RechearComPresunto();
            

            Assert.IsTrue(paoFrances.Valor == 2);
            Assert.IsTrue(paoComQueijo.Valor == 6);
            Assert.IsTrue(paoComQueijoPresunto.Valor == 10);

            Console.WriteLine($"{paoFrances.Nome} = {paoFrances.Valor}");
            Console.WriteLine($"{paoComQueijo.Nome} = {paoComQueijo.Valor}");
            Console.WriteLine($"{paoComQueijoPresunto.Nome} = {paoComQueijoPresunto.Valor}");
        }

        [TestMethod]
        public void BagueteComPresuntoEQueijo()
        {
            var baguete = new Baguete();

            var paoComQueijo = new RecheioQueijo(baguete);
            var paoComQueijoPresunto = new RecheioPresunto(paoComQueijo);

            Assert.IsTrue(baguete.Valor == 5);
            Assert.IsTrue(paoComQueijo.Valor == 8);
            Assert.IsTrue(paoComQueijoPresunto.Valor == 12);

            Console.WriteLine($"{baguete.Nome} = {baguete.Valor}");
            Console.WriteLine($"{paoComQueijo.Nome} = {paoComQueijo.Valor}");
            Console.WriteLine($"{paoComQueijoPresunto.Nome} = {paoComQueijoPresunto.Valor}");
        }
    }
}
