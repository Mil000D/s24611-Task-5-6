using ObjectPoolPattern.ReusableLaptop;

namespace ObjectPoolPattern
{
    class Worker
    {
        public string Name { get; }

        public Worker(string name)
        {
            Name = name;
        }

        public void PerformTask(Laptop laptop)
        {
            Console.WriteLine($"{Name} is performing a task using laptop {laptop.Id}");
        }
    }
}
