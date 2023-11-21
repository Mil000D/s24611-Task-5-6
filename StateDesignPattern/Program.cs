using StateDesignPattern.Life;
namespace StateDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            HumanLife human = new HumanLife();

            human.Live();
            human.Live();
            human.Live();
            human.Live();
        }
    }
}