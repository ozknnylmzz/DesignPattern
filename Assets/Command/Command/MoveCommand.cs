using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class MoveCommand : ICommand
    {
        private PlayerMover _playerMover;
        private Vector3 _movement;

        public MoveCommand(PlayerMover playerMover,Vector3 movement)
        {
            _playerMover = playerMover;
            _movement = movement;
        }
        
        public void Execute()
        {
            _playerMover.Move(_movement);
        }

        public void Undo()
        {
            _playerMover.Move(-_movement);
        }
    }
}

