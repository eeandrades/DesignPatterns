using System;

namespace DesignPatterns.Builder
{
    public class CarBuilder : ICarBuilder
    {
        private readonly Car _car = new Car();

        public CarBuilder()
        {

        }

        public Car Build()
        {
            return this._car;
        }

        private ICarBuilder Assign(Action action)
        {
            action.Invoke();
            return this;
        }

        ICarBuilder ICarBuilder.BuildChassis(string description) =>
            this.Assign(() => this._car.AddComponent(new Chassis(description)));

        ICarBuilder ICarBuilder.BuildSteeringWheel(string description) =>
            this.Assign(() => this._car.AddComponent(new SteeringWheel(description)));

        ICarBuilder ICarBuilder.BuildWheel(string description) =>
            this.Assign(() => this._car.AddComponent(new Wheel(description)));
    }
}