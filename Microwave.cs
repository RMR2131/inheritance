using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1;
    class Microwave : Appliance
{
    public double Capacity { get; set; }
    public string RoomType { get; set; }
    public Microwave(string id, string brand, int quantity, double wattage, string color, double price, double capacity, string roomType)
        : base(id, brand, quantity, wattage, color, price)
    {
        Capacity = capacity;
        RoomType = roomType;
    }

    public override string ToString()
    {
        return "ID: " + ID + "\nBrand:" + Brand + "\nQuantity:" + Quantity + "\nWattage:" + Wattage + "\nColor:" + Color + "\nPrice:" + Price + "\nCapacity:" + Capacity + "\nRoomType:" + RoomType;
    }

    public override void Purchase()
    {
        Quantity--;
    }
}
