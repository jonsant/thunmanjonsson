namespace Factory_Pattern.Factory_Method
{
    public class Bicycle : IVehicle
    {
        public string About() => $"I have two wheels";

        public void Prepare()
        {
            // Prepare the bicycle...
        }
    }
}
