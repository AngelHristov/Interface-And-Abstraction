namespace _03.Ferrari
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            Ferrari ferrari = new Ferrari(name, "488-Spider");

            Console.WriteLine($"" +
                $"{ferrari.Model}" +
                $"/{ferrari.UseBrakes()}" +
                $"/{ferrari.PushTheGasPedal()}" +
                $"/{ferrari.Name}");
        }
    }
}
