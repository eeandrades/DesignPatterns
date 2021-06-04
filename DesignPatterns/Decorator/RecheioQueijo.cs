namespace DesignPatterns.Decorator
{
    public class RecheioQueijo : PaoRecheadoDecorator
    {
        public RecheioQueijo(Pao pao) : base(pao)
        {

        }
        protected override int GetValorDecorator()
        {
            return 3;
        }

        protected override string GetNomeDecorator()
        {
            return "Queijo";
        }
    }
}
