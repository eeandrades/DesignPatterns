using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Wheel : CarComponent
    {
        public Wheel(string describle) : base(describle)
        {
        }
    }

    public class Chassis : CarComponent
    {
        public Chassis(string describle) : base(describle)
        {
        }
    }

    public class SteeringWheel : CarComponent
    {
        public SteeringWheel(string describle) : base(describle)
        {
        }
    }
}
