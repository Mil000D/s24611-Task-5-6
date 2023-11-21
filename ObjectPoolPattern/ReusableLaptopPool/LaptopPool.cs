using ObjectPoolPattern.ReusableLaptop;

namespace ObjectPoolPattern.ReusableLaptopPool
{
    class LaptopPool
    {
        private List<Laptop> _pool;
        private int _maxSize;

        public LaptopPool(int maxSize)
        {
            this._maxSize = maxSize;
            _pool = new List<Laptop>();
            InitializePool();
        }

        private void InitializePool()
        {
            for (int i = 0; i < _maxSize; i++)
            {
                _pool.Add(CreateLaptop());
            }
        }
        public Laptop AcquireLaptop()
        {
            if (_pool.Count > 0)
            {
                Laptop laptop = _pool[0];
                _pool.RemoveAt(0);
                Console.WriteLine($"Retrieved laptop {laptop.Id} from the pool");
                return laptop;
            }
            else
            {
                Console.WriteLine("Pool is empty. Buying a new laptop.");
                return CreateLaptop();
            }
        }

        public void ReleaseLaptop(Laptop laptop)
        {
            if (_pool.Count < _maxSize)
            {
                _pool.Add(laptop);
                Console.WriteLine($"Releasing laptop {laptop.Id} back to the pool");
            }
            else
            {
                Console.WriteLine($"Pool is full. Destroying laptop {laptop.Id}");
            }
        }

        private Laptop CreateLaptop()
        {
            Laptop laptop = new Laptop();
            Console.WriteLine($"Bought a new laptop {laptop.Id}");
            return laptop;
        }
    }
}
