namespace Factory_Pattern.Abstract_Factory
{
    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBicycle CreateBicycle()
        {
            return new SportsBicycle();
        }

        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }
}
