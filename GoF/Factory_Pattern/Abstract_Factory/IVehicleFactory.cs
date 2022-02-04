namespace Factory_Pattern.Abstract_Factory
{
    public interface IVehicleFactory
    {
        ICar CreateCar();

        IBicycle CreateBicycle();
    }
}
