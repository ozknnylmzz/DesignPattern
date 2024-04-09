
namespace DesignPattern.State
{
    public interface IState
    {
        public void EnterState();
        public void Update();
        public void ExitState();
    }
}

