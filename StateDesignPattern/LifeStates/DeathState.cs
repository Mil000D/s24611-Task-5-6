using StateDesignPattern.Life;

namespace StateDesignPattern.LifeStages
{
    public class DeathState : ILifeState
    {
        private HumanLife life;

        public DeathState(HumanLife life)
        {
            this.life = life;
        }

        public void Experience()
        {
            Console.WriteLine("Death - The journey has ended.");
        }
    }
}
