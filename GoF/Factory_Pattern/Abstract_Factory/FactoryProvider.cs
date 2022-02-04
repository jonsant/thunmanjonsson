namespace Factory_Pattern.Abstract_Factory
{
    public static class FactoryProvider
    {
        public static IVehicleFactory GetVehicleFactory(string theme)
        {
            if (theme.Contains("regular"))
            {
                return new RegularVehicleFactory();
            }
            else if (theme.Contains("sports"))
            {
                return new SportsVehicleFactory();
            }
            else
            {
                throw new ArgumentException("Couldn't find valid theme");
            }
        }
    }
}
