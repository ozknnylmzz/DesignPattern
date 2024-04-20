using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern.Strategy
{
    public class MeleeAbility : AbilityStrategy
    {
        public override void UseAbility(Transform desiredPosition)
        {
            Debug.Log("Laying down the smack down!");
        }
    }
}

