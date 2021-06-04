namespace DesignPatterns.Decorator
{
    public class Baguete : Pao
    {
        protected override int GetValor()
        {
            return 5;    
        }

        protected override string GetNome()
        {
            return "Baguete";
        }
    }
}