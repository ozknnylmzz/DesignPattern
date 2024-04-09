using System.Collections;
using UnityEngine;

namespace DesignPattern.State
{
    public class AttackState : IState
    {
        private PlayerControllerSM _playerSM;
        
        public AttackState(PlayerControllerSM playerSM)
        {
            _playerSM = playerSM;
        }
        
        public void EnterState()
        {
            Debug.Log("code that runs when we first enter the state");
        }

        public void Update()
        {
            // Here we add logic to detect if the conditions exist to
            _playerSM.ChangeState(_playerSM.IdleState);
        }

        public void ExitState()
        {
            
        }
    }
}


