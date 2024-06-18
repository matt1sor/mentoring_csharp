using System;
namespace Vehicle
{
    public class Vehicle
    {
        private string model;
        private string color;
        private string gearboxType;
        
        public Vehicle(string model, string color, string gearboxType)
        {
            this.model = model;
            this.color = color;
            this.gearboxType = gearboxType;
        }

       public Vehicle Clone()
        {
            return (Vehicle)this.MemberwiseClone();
        }

        public void ChangeModel(string newModel)
        {
            model = newModel;
        }
        
        public void ChangeColor(string newColor)
        {
            color = newColor;
        }
        
        public void ChangeGearbox(string newGearbox)
        {
            gearboxType = newGearbox;
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"Model: {model}, Color: {color}, Gearbox Type: {gearboxType}");
        }

    }
}