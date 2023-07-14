using System;

namespace ObjectOrientedProject
{
    using System;
    using System.Collections.Generic;

    // Data abstraction
    abstract class Vehicle
    {
        public abstract void Start();
        public abstract void Stop();
    }

    // Encapsulation
    class Car : Vehicle
    {
        private string brand;
        private string model;
        private int year;

        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public override void Start()
        {
            Console.WriteLine("Starting the car.");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the car.");
        }
    }

    class Motorcycle : Vehicle
    {
        private string brand;
        private string model;
        private int year;

        public Motorcycle(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public override void Start()
        {
            Console.WriteLine("Starting the motorcycle.");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the motorcycle.");
        }
    }

    // Inheritance
    class Truck : Vehicle
    {
        private string brand;
        private string model;
        private int year;

        public Truck(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public override void Start()
        {
            Console.WriteLine("Starting the truck.");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the truck.");
        }
    }

    // Multi-level inheritance
    class FireTruck : Truck
    {
        private int waterCapacity;

        public FireTruck(string brand, string model, int year, int waterCapacity)
            : base(brand, model, year)
        {
            this.waterCapacity = waterCapacity;
        }

        public void SprayWater()
        {
            Console.WriteLine($"Spraying water with the fire truck. Water capacity: {waterCapacity} gallons.");
        }
    }

    // Polymorphism
    class VehicleManager
    {
        private List<Vehicle> vehicles;

        public VehicleManager()
        {
            vehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void StartAllVehicles()
        {
            Console.WriteLine("Starting all vehicles:");
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Start();
            }
            Console.WriteLine();
        }

        public void StopAllVehicles()
        {
            Console.WriteLine("Stopping all vehicles:");
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Stop();
            }
            Console.WriteLine();
        }
    }

    // Real-world application with multi-level inheritance
    class Program
    {
        static void Main(string[] args)
        {
            VehicleManager manager = new VehicleManager();

            Car car = new Car("Toyota", "Camry", 2020);
            Motorcycle motorcycle = new Motorcycle("Honda", "CBR500R", 2021);
            Truck truck = new Truck("Ford", "F-150", 2019);
            FireTruck fireTruck = new FireTruck("Mercedes-Benz", "Actros", 2022, 1000);

            manager.AddVehicle(car);
            manager.AddVehicle(motorcycle);
            manager.AddVehicle(truck);
            manager.AddVehicle(fireTruck);

            manager.StartAllVehicles();
            manager.StopAllVehicles();

            fireTruck.SprayWater();
        }
    }

}
