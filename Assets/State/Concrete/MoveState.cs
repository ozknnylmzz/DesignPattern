using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern.State
{
    public class MoveState : IState
    {
        private PlayerControllerSM _playerSM;
        public MoveState(PlayerControllerSM playerSM)
        {
            _playerSM = playerSM;
        }   
        
        public void EnterState()
        {
            
        }

        public void Update()
        {
            _playerSM.ChangeState(_playerSM.IdleState);
        }

        public void ExitState()
        {
            
        }

    }
}

