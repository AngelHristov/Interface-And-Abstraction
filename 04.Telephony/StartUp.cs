namespace _04.Telephony
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] numbers = Splitter();

            Caller(numbers);

            string[] urls = Splitter();

            Browser(urls);
        }

        private static void Browser(string[] urls)
        {
            foreach (var num in urls)
            {
                IBrowser smartphone = new Smartphone();
                Console.WriteLine(smartphone.BrowseWWW(num));
            }
        }

        private static void Caller(string[] numbers)
        {
            foreach (var num in numbers)
            {
                ICaller smartphone = new Smartphone();
                Console.WriteLine(smartphone.CallOtherPhones(num)); 
            }
        }

        private static string[] Splitter()
        {
            return Console.ReadLine()
                .Split();
        }
    }
}
