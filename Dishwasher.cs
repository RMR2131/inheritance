using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1;
    class Dishwasher : Appliance
{
    public string Feature { get; set; }
    public string SoundRating { get; set; }
    public Dishwasher(string id, string brand, int quantity, double wattage, string color, double price, string feature, string soundRating)
        : base(id, brand, quantity, wattage, color, price)
    {
        Feature = feature;
        SoundRating = soundRating;
    }

    public override string ToString()
    {
        return "ID: " + ID + "\nBrand:" + Brand + "\nQuantity:" + Quantity + "\nWattage:" + Wattage + "\nColor:" + Color + "\nPrice:" + Price + "\nFeature:" + Feature + "\nSoundRating:" + SoundRating;
    }

    public override void Purchase()
    {
        Quantity--;
    }
}

