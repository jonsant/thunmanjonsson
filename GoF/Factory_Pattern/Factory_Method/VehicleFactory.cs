namespace Factory_Pattern.Factory_Method
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();

        public IVehicle MakeVehicle()
        {
            IVehicle vehicle = CreateVehicle();
            vehicle.Prepare();

            return vehicle;
        }
    }
}
