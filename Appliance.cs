using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1;

    class Appliance
{
    public string ID { get; set; }
    public string Brand { get; set; }
    public int Quantity { get; set; }
    public double Wattage { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }
    public Appliance(string id, string brand, int quantity, double wattage, string color, double price)
    {
        ID = id;
        Brand = brand;
        Quantity = quantity;
        Wattage = wattage;
        Color = color;
        Price = price;
    }
    public override string ToString()
    {
        return "ID: " + ID + "\nBrand:" + Brand + "\nQuantity:" + Quantity + "\nWattage:" + Wattage + "\nColor:" + Color + "\nPrice:" + Price;
    }

    public virtual void Purchase()
    {
        Quantity--;
    }
}

