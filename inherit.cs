/*
SportsCar derived from Vehicle class
*/

using System;

class Vehicle
{
	public string model;
	public string manufacturer;
	public float price;
}

class SportCar: Vehicle
{
	public Boolean driverTrained;
	public float boosterSize;
}

class MainClass
{
	static void Main(String[] args)
	{
		SportCar sc  = new SportCar();
		sc.driverTrained = true;
		sc.boosterSize = 45.3f;
		sc.manufacturer = "Boogati";
		sc.model = "Wayron";
		sc.price = 52.23f;

		Console.WriteLine("Car details");
		Console.WriteLine("--------------------------------------------");
		Console.WriteLine("Name: " + sc.manufacturer + " " + sc.model);
		Console.WriteLine("Price: Rs." + sc.price + " lakh");
		Console.WriteLine("Booster size: " + sc.boosterSize + "x");
		Console.WriteLine("Is trained driver required? " + sc.driverTrained);
	}
}