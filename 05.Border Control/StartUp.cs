namespace _05.Border_Control
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<IID> someone = new List<IID>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split();

                string name = tokens[0];
                
                if (tokens.Length == 3)
                {
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];
                    
                    Citizen citizen = new Citizen(name, age, id);
                    someone.Add(citizen);
                }
                else
                {
                    string id = tokens[1];

                    Robot robot = new Robot(name, id);
                    someone.Add(robot);
                }
            }

            string fakeId = Console.ReadLine();

            foreach (var ids in someone)
            {
                if (ids.ID.EndsWith(fakeId))
                {
                    Console.WriteLine(ids.ID);
                }
            }
        }
    }
}
