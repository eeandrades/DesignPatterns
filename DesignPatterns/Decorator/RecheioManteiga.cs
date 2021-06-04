namespace DesignPatterns.Decorator
{
    public class RecheioManteiga : PaoRecheadoDecorator
    {
        public RecheioManteiga(Pao pao) : base(pao)
        {

        }
        protected override int GetValorDecorator()
        {
            return 1;
        }

        protected override string GetNomeDecorator()
        {
            return "Manteiga";
        }
    }
}
