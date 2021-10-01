namespace DesignPatterns.Builder
{
    public class PopularCarFactory
    {
        private ICarBuilder _builder;

        public ICarBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public Car Build() =>
            this._builder
                .BuildChassis("Chassis simples")
                .BuildSteeringWheel("Volante plastico")
                .BuildWheel("Roda dianteira esquerda aro 13")
                .BuildWheel("Roda dianteira direita aro 13")
                .BuildWheel("Roda trazeira direita aro 13")
                .BuildWheel("Roda trazeira esquerda aro 13")
                .Build();
    }
}