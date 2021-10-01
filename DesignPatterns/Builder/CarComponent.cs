using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public abstract class CarComponent
    {
        public CarComponent(string describle)
        {
            Describle = describle;
        }

        public string Describle { get; }
    }
}
