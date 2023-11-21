using StateDesignPattern.Life;
namespace StateDesignPattern.LifeStages
{
    public class AdulthoodState : ILifeState
    {
        private HumanLife life;

        public AdulthoodState(HumanLife life)
        {
            this.life = life;
        }

        public void Experience()
        {
            Console.WriteLine("Adulthood: Working and building a career.");
            life.SetState(new SeniorAgeState(life));
        }
    }
}
