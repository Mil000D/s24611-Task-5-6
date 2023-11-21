using StateDesignPattern.Life;
namespace StateDesignPattern.LifeStages
{
    public class ChildhoodState : ILifeState
    {
        private HumanLife life;

        public ChildhoodState(HumanLife life)
        {
            this.life = life;
        }

        public void Experience()
        {
            Console.WriteLine("Childhood - Learning and playing.");
            life.SetState(new AdulthoodState(life));
        }
    }
}
