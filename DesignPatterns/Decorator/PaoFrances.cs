namespace DesignPatterns.Decorator
{
    public class PaoFrances : Pao
    {
        protected override int GetValor()
        {
            return 2;    
        }

        protected override string GetNome()
        {
            return "Pão Francês";
        }
    }
}