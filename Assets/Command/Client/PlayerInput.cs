using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Command
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private PlayerMover _playerMover;
        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                RunPlayerCommand(Vector3.left);
            }
            
            if (Input.GetKey(KeyCode.RightArrow))
            {
                RunPlayerCommand(Vector3.right);
            }
            
            if (Input.GetKey(KeyCode.UpArrow))
            {
                RunPlayerCommand(Vector3.up);
            }
            
            if (Input.GetKey(KeyCode.DownArrow))
            {
                RunPlayerCommand(Vector3.down);
            }

            if (Input.GetKey(KeyCode.R))
            {
                CommandInvoker.UndoCommand();
            }
        }
    
        private void RunPlayerCommand(Vector3 movement)
        {
            ICommand command = new MoveCommand(_playerMover, movement);
            CommandInvoker.ExecuteCommand(command);
        }
       
    }
}

