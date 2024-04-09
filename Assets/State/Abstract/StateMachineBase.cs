using UnityEngine;

namespace DesignPattern.State
{
    public abstract class StateMachineBase : MonoBehaviour
    {
        public IState CurrentState;

      

        private void Update()
        {
            if (CurrentState!=null)
            {
                CurrentState.Update();
            }
        }

        public void ChangeState(IState nextState)
        {
            CurrentState.ExitState();

            CurrentState = nextState;

            CurrentState.EnterState();
        }

    }
}