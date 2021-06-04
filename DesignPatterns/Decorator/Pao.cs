namespace DesignPatterns.Decorator
{
    public abstract class Pao
    {
        public string Nome => this.GetNome();
        public int Valor => GetValor();
        protected abstract int GetValor();
        protected abstract string GetNome();


    }
}
