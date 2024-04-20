using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern.Strategy
{
    public class HealAbility : AbilityStrategy
    {
        public override void UseAbility(Transform desiredPosition)
        {
            Debug.Log("This should cure your wounds");
        }
    }
}

