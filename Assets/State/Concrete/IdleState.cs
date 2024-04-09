
namespace DesignPattern.State
{
    public class IdleState : IState
    {
        private PlayerControllerSM _playerSM;
        public IdleState(PlayerControllerSM playerSM)
        {
            _playerSM = playerSM;
        }
        
        public void EnterState()
        {
            
        }

        public void Update()
        {
            // Here we add logic to detect if the conditions exist to
        }

        public void ExitState()
        {
        }
    } 
}

