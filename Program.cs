using CarFabric;

List<Car> Carlist = new List<Car>(); //A new list has been created to hold the list of cars.

Start: //A starting point.
    Console.Write("Do you want to produce cars? ( Y/N ): ");
    string answer = Console.ReadLine().ToLower();

if (answer == "Y" || answer == "y" || answer == "N" || answer=="n") //Some conditions for the response received from the user.
{
    if (answer == "Y" || answer == "y") //We get car features from the user.
    {
        DateTime productionDate = DateTime.Now;

        Console.Write("\nEnter a serial number: ");
        string serialNumber = Console.ReadLine();

        Console.Write("Enter a brand: ");
        string brand = Console.ReadLine();

        Console.Write("Enter a Model: ");
        string Model = Console.ReadLine();

        Console.Write("Enter a Color: ");
        string Color = Console.ReadLine();

        Begin: //A starting point.
        Console.Write("Enter a DoorNumber: ");
        int DoorNumber = 0;
        string input = Console.ReadLine();

        try //Try-catch to give a warning even if the door number is entered incorrectly.
        {
                DoorNumber = Convert.ToInt32(input);

            if (DoorNumber > 4 || DoorNumber <= 1)
            {
                Console.WriteLine("Incorrect entered, please enter a valid number.");
                goto Begin;
            }     
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format, please enter a valid number.");
                goto Begin;
            }
      
                Car car = new Car(productionDate, serialNumber, brand, Model, Color, DoorNumber); //Car class defined.
                Console.WriteLine("\nCar produced succsessfully!\n");

                Carlist.Add(car); //generated car objects added to the list
                goto Start;
    }
    else
    { 
        foreach (Car car in Carlist) //Some specifications of the car list have been printed.
        {
            Console.WriteLine("\nSerial Number: " + car.SerialNumber + " " + "Brand: " +  car.Brand);
        }
    }
}
else
{
    Console.WriteLine("\nIncorrect enter, please enter a valid answer.\n"); //When there is an entry other than the given conditions, it returns to the starting point.
    goto Start;
}

Console.WriteLine("\nPress a key to exit.");
Console.ReadKey();
    
    