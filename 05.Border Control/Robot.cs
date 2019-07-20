namespace _05.Border_Control
{
    public class Robot : IID
    {
        public Robot(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }

        public string ID { get; private set; }

        public string Name { get; set; }
    }
}
