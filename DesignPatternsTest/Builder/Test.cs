using DesignPatterns.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.Builder
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void CreatePopularCar()
        {
        
            var factory = new PopularCarFactory();
            factory.Builder = new CarBuilder();

            var car = factory.Build();

            foreach(var carComponent in car.Components)
            {
                Console.WriteLine(carComponent.Describle);
            }

        }
    }
}
