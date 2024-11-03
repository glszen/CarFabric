using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFabric
{
    public class Car //We create a class to hold car properties.
    {

        public DateTime ProductionDate { get; set; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorNumber { get; set; }

        public Car (DateTime productionDate, string serialNumber, string brand, string model, string color, int doorNumber)
        {
            ProductionDate = productionDate;
            SerialNumber = serialNumber;
            Brand = brand;
            Model = model;
            Color = color;
            DoorNumber = doorNumber;
        }

        public override string ToString() //ToString Method: By adding the ToString method to the Car class, we ensure that it returns car information in a formatted manner.
        {
            return $"\nProduction Date: {ProductionDate.ToShortDateString()}\n" + 
                   $"Serial Number: {SerialNumber}\n" +
                   $"Brand: {Brand}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Door Number: {DoorNumber}\n";
        }

    }
}
