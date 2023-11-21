using StateDesignPattern.Life;

namespace StateDesignPattern.LifeStages
{
    public class SeniorAgeState : ILifeState
    {
        private HumanLife life;

        public SeniorAgeState(HumanLife life)
        {
            this.life = life;
        }

        public void Experience()
        {
            Console.WriteLine("Senior Age - Enjoying retirement time.");
            life.SetState(new DeathState(life));
        }
    }
}
