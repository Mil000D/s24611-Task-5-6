namespace ObjectPoolPattern.ReusableLaptop
{
    public class Laptop
    {
        public string Id { get; }

        public Laptop()
        {
            Id = Guid.NewGuid().ToString().Substring(0, 8);
        }
    }
}
