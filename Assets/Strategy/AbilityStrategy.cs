
using UnityEngine;

namespace DesignPattern.Strategy
{
    public abstract class AbilityStrategy : ScriptableObject
    {
        public abstract void UseAbility(Transform desiredPosition);
    }
}
