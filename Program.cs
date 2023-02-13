using System;
using System.Collections.Generic;
using System.IO;
namespace Assignmemnt1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Appliance> applianceList = new List<Appliance>();
            // Read in the employees.txt file
            using (StreamReader reader = new StreamReader("res/appliances.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] splitLine = line.Split(';');
                    // Create new employee objects and add them to the list
                    if (splitLine[0].StartsWith("1"))
                    {
                        Refrigerator refrigerator = new Refrigerator(splitLine[0], splitLine[1], int.Parse(splitLine[2]), double.Parse(splitLine[3]), splitLine[4], double.Parse(splitLine[5]), int.Parse(splitLine[6]), int.Parse(splitLine[7]), int.Parse(splitLine[8]));
                        applianceList.Add(refrigerator);
                    }
                    else if (splitLine[0].StartsWith("2"))
                    {
                        Vacuum vacuum = new Vacuum(splitLine[0], splitLine[1], int.Parse(splitLine[2]), double.Parse(splitLine[3]), splitLine[4], double.Parse(splitLine[5]), splitLine[6], int.Parse(splitLine[7]));
                        applianceList.Add(vacuum);
                    }
                    else if (splitLine[0].StartsWith("3"))
                    {
                        Microwave microwave = new Microwave(splitLine[0], splitLine[1], int.Parse(splitLine[2]), double.Parse(splitLine[3]), splitLine[4], double.Parse(splitLine[5]), double.Parse(splitLine[6]), splitLine[7]);
                        applianceList.Add(microwave);
                    }
                    else if (splitLine[0].StartsWith("4") || splitLine[0].StartsWith("5"))
                    {
                        Dishwasher dishwasher = new Dishwasher(splitLine[0], splitLine[1], int.Parse(splitLine[2]), double.Parse(splitLine[3]), splitLine[4], double.Parse(splitLine[5]), splitLine[6], splitLine[7]);
                        applianceList.Add(dishwasher);
                    }
                }

                while (true)
                {
                    int choice, type, door, battery, num, ranNum;
                    string itemNumber, brand, roomType, soundRating;
                    bool available = false;
                    Console.WriteLine("Welcome to Modern Appliances!");
                    Console.WriteLine("How we may assist you?");
                    Console.WriteLine("1 - Check out appliance");
                    Console.WriteLine("2 - Find appliances by brand");
                    Console.WriteLine("3 - Display appliances by type");
                    Console.WriteLine("4 - Produce random appliance list");
                    Console.WriteLine("5 - Save & exit");
                    Console.WriteLine("Enter option:");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.WriteLine("Enter the item number of an appliance:");
                        itemNumber = Console.ReadLine();

                        foreach (Appliance appliance in applianceList)
                        {
                            if (itemNumber == appliance.ID)
                            {
                                available = true;
                                if (appliance.Quantity > 0)
                                {
                                    appliance.Purchase();
                                    Console.WriteLine("Appliance " + appliance.ID + " has been checked out");
                                }
                                else if (appliance.Quantity == 0)
                                {
                                    Console.WriteLine("Appliance is not available to be checkout");
                                }
                            }
                        }

                        if (!available)
                        {
                            Console.WriteLine("No appliances found with that item number.");
                        }
                    }

                    if (choice == 2)
                    {
                        Console.WriteLine("Enter brand to search for:");
                        brand = Console.ReadLine();
                        Console.WriteLine("Matching Appliances:");
                        foreach (Appliance appliance in applianceList)
                        {
                            if (appliance.Brand == brand)
                            {
                                Console.WriteLine(appliance);
                            }
                        }
                    }

                    if (choice == 3)
                    {
                        Console.WriteLine("Appliance Types");
                        Console.WriteLine("1 - Refrigerator");
                        Console.WriteLine("2 - Vacuums");
                        Console.WriteLine("3 - Microwaves");
                        Console.WriteLine("4 - Dishwashers");
                        Console.WriteLine("Enter type of appliance:");
                        type = Convert.ToInt32(Console.ReadLine());

                        if (type == 1)
                        {
                            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):");
                            door = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Matching refrigerators:");
                            foreach (Appliance appliance in applianceList)
                            {
                                if (appliance is Refrigerator)
                                {
                                    Refrigerator refrigerator = (Refrigerator)appliance;
                                    if (refrigerator.NumberOfDoor == door)
                                    {
                                        Console.WriteLine(refrigerator);
                                    }
                                }
                            }
                        }
                        else if (type == 2)
                        {
                            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high):");
                            battery = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Matching vacuums:");
                            foreach (Appliance appliance in applianceList)
                            {
                                if (appliance is Vacuum)
                                {
                                    Vacuum vacuum = (Vacuum)appliance;
                                    if (vacuum.BatteryVoltage == battery)
                                    {
                                        Console.WriteLine(vacuum);
                                    }
                                }
                            }
                        }
                        else if (type == 3)
                        {
                            Console.WriteLine("RoomWhere the microwave will be installed: K (kitchen) or W (work site):");
                            roomType = Console.ReadLine();
                            Console.WriteLine("Matching microwaves:");
                            foreach (Appliance appliance in applianceList)
                            {
                                if (appliance is Microwave)
                                {
                                    Microwave microwave = (Microwave)appliance;
                                    if (microwave.RoomType == roomType)
                                    {
                                        Console.WriteLine(microwave);
                                    }
                                }
                            }
                        }
                        else if (type == 4)
                        {
                            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");
                            soundRating = Console.ReadLine();
                            Console.WriteLine("Matching dishwashers:");
                            foreach (Appliance appliance in applianceList)
                            {
                                if (appliance is Dishwasher)
                                {
                                    Dishwasher dishwasher = (Dishwasher)appliance;
                                    if (dishwasher.SoundRating == soundRating)
                                    {
                                        Console.WriteLine(dishwasher);
                                    }
                                }
                            }
                        }
                    }

                    if (choice == 4)
                    {
                        Random rnd = new Random();
                        Console.WriteLine("Enter number of appliances: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Random appliances:");
                        for (int i = 0; i < num; i++)
                        {
                            ranNum = rnd.Next(0, applianceList.Count);
                            Console.WriteLine(applianceList[ranNum]);
                        }
                    }

                    if (choice == 5)
                    {
                        break;
                    }
                }
            }
        }
    }
}
