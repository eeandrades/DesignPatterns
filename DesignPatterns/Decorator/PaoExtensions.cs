using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public static class PaoExtensions
    {
        public static PaoRecheadoDecorator RechearComPresunto (this Pao pao)
        {
            return new RecheioPresunto(pao);
        }

        public static PaoRecheadoDecorator RechearComQueijo(this Pao pao)
        {
            return new RecheioQueijo(pao);
        }

        public static PaoRecheadoDecorator PassarManteiga(this Pao pao)
        {
            return new RecheioManteiga(pao);
        }
    }
}
