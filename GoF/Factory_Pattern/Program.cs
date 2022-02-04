using Factory_Pattern.Factory_Method;
using Factory_Pattern.Abstract_Factory;

// Factory Method client

VehicleFactory carFactory = new CarFactory();
VehicleFactory bicycleFactory = new BicycleFactory();

IVehicle car = carFactory.MakeVehicle();
IVehicle bicycle = bicycleFactory.MakeVehicle();

Console.WriteLine(car.About()); // I have four wheels and a motor
Console.WriteLine(bicycle.About()); // I have two wheels

// Abstract Factory client

IVehicleFactory vehicleFactory = FactoryProvider.GetVehicleFactory("sports");

IBicycle myBicycle = vehicleFactory.CreateBicycle();
ICar myCar = vehicleFactory.CreateCar();

Console.WriteLine(myBicycle.About()); // I'm a sports bicycle
Console.WriteLine(myCar.About()); // I'm a sports car