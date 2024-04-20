using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern.Strategy
{
    [CreateAssetMenu]
    public class FireBallAbility : AbilityStrategy
    {
        public override void UseAbility(Transform desiredPosition)
        {
            Debug.Log("Launch Fireball");
        }
    }
}

