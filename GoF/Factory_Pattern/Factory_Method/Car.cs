namespace Factory_Pattern.Factory_Method
{
    public class Car : IVehicle
    {
        public string About() => $"I have four wheels and a motor";

        public void Prepare()
        {
            // Prepare the car...
        }
    }
}
