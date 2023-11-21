using ObjectPoolPattern.ReusableLaptop;
using ObjectPoolPattern.ReusableLaptopPool;

namespace ObjectPoolPattern
{
    public class Program
    {
        public static void Main()
        {
            LaptopPool laptopPool = new LaptopPool(3);

            Worker worker1 = new Worker("John");
            Worker worker2 = new Worker("Alice");

            Laptop laptop1 = laptopPool.AcquireLaptop();
            worker1.PerformTask(laptop1);

            Console.WriteLine();

            Laptop laptop2 = laptopPool.AcquireLaptop();
            worker2.PerformTask(laptop2);

            Console.WriteLine();

            laptopPool.ReleaseLaptop(laptop1);
            laptopPool.ReleaseLaptop(laptop2);

            Console.WriteLine();

            Laptop laptop3 = laptopPool.AcquireLaptop();
            worker1.PerformTask(laptop3);

            Console.WriteLine();

            Laptop laptop4 = laptopPool.AcquireLaptop();
            worker2.PerformTask(laptop4);

            Console.WriteLine();

            Worker worker3 = new Worker("Charlie");
            Laptop laptop5 = laptopPool.AcquireLaptop();
            worker3.PerformTask(laptop5);

            Console.WriteLine();

            Worker worker4 = new Worker("Dave");
            Laptop laptop6 = laptopPool.AcquireLaptop();
            worker4.PerformTask(laptop6);

            Console.WriteLine();

            laptopPool.ReleaseLaptop(laptop3);
            laptopPool.ReleaseLaptop(laptop4);
            laptopPool.ReleaseLaptop(laptop5);
            laptopPool.ReleaseLaptop(laptop6);
        }
    }
}