namespace _05.Border_Control
{
    public class Citizen : IID
    {
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.ID = id;
        }

        public string ID { get; private set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
