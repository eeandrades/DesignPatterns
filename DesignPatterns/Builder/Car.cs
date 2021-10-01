using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Car
    {
        private List<CarComponent> _components = new List<CarComponent>();

        public IEnumerable<CarComponent> Components => this._components.AsEnumerable();

        public void AddComponent(CarComponent component)
        {
            this._components.Add(component);
        }
    }
}
