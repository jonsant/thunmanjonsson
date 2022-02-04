namespace Factory_Pattern.Factory_Method
{
    public class BicycleFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Bicycle();
        }
    }
}
