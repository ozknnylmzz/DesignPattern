using System;
using UnityEngine;

namespace DesignPattern.State
{
    public class PlayerControllerSM : StateMachineBase
    {
        public AttackState AttackState { get; private set; }
        public IdleState IdleState { get; private set; }
        public MoveState MoveState { get; private set; }

        private void Awake()
        {
            AttackState = new AttackState(this);
            IdleState = new IdleState(this);
            MoveState = new MoveState(this);
        }
        
        private void Start()
        {
            ChangeState(IdleState);
        }
    }
}