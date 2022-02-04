namespace Factory_Pattern.Abstract_Factory
{
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBicycle CreateBicycle()
        {
            return new RegularBicycle();
        }

        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }
}
