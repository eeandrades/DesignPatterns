namespace DesignPatterns.Decorator
{
    public abstract class PaoRecheadoDecorator: Pao
    {
        protected Pao Pao { get; }
        protected PaoRecheadoDecorator(Pao pao)
        {
            this.Pao = pao;
        }

        protected override string GetNome()
        {
            return $"{this.Pao.Nome } com {this.GetNomeDecorator()}";
        }

        protected override int GetValor()
        {
            return this.Pao.Valor + this.GetValorDecorator();
        }        
        protected abstract int GetValorDecorator();
        protected abstract string GetNomeDecorator();
    }
}
