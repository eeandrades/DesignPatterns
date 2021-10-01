namespace DesignPatterns.Builder
{
    public interface ICarBuilder
    {
        ICarBuilder BuildWheel(string description);

        ICarBuilder BuildSteeringWheel(string description);

        ICarBuilder BuildChassis(string description);

        Car Build();
    }
}