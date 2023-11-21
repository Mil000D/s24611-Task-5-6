using StateDesignPattern.LifeStages;

namespace StateDesignPattern.Life
{
    public class HumanLife
    {
        private ILifeState state;

        public HumanLife()
        {
            state = new ChildhoodState(this);
        }

        public void SetState(ILifeState state)
        {
            this.state = state;
        }

        public void Live()
        {
            state.Experience();
        }
    }
}
