namespace DesignPatterns.Decorator
{
    public class RecheioPresunto: PaoRecheadoDecorator
    {
       public RecheioPresunto(Pao pao) : base(pao)
        {
             
        }
        protected override int GetValorDecorator()
        {
            return 4;
        }

        protected override string GetNomeDecorator()
        {
            return "Presunto";
        }
    }
}
