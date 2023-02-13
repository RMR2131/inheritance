using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1;

    class Refrigerator : Appliance
{
    public int NumberOfDoor { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public Refrigerator(string id, string brand, int quantity, double wattage, string color, double price, int numberOfDoor, int height, int width)
        : base(id, brand, quantity, wattage, color, price)
    {
        NumberOfDoor = numberOfDoor;
        Height = height;
        Width = width;
    }

    public override string ToString()
    {
        return "ID: " + ID + "\nBrand:" + Brand + "\nQuantity:" + Quantity + "\nWattage:" + Wattage + "\nColor:" + Color + "\nPrice:" + Price + "\nNumberOfDoor:" + NumberOfDoor + "\nHeight:" + Height + "\nWidth:" + Width;
    }

    public override void Purchase()
    {
        Quantity--;
    }
}

class Vacuum : Appliance
{
    public int BatteryVoltage { get; set; }
    public string Grade { get; set; }
    public Vacuum(string id, string brand, int quantity, double wattage, string color, double price, string grade, int batteryVoltage)
        : base(id, brand, quantity, wattage, color, price)
    {
        Grade = grade;
        BatteryVoltage = batteryVoltage;
    }

    public override string ToString()
    {
        return "ID: " + ID + "\nBrand:" + Brand + "\nQuantity:" + Quantity + "\nWattage:" + Wattage + "\nColor:" + Color + "\nPrice:" + Price + "\nGrade:" + Grade + "\nBatteryVoltage:" + BatteryVoltage;
    }

    public override void Purchase()
    {
        Quantity--;
    }
}
