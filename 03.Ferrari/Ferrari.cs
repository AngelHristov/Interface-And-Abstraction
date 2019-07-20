namespace _03.Ferrari
{
    using System;

    public class Ferrari : IFerrari
    {
        public Ferrari(string name, string model)
        {
            this.Name = name;
            this.Model = model;
        }

        public string Name { get; private set; }

        public string Model { get; private set; } 



        public string PushTheGasPedal()
        {
            return "Gas!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }
    }
}