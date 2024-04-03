using UnityEngine;

namespace DesignPattern
{
    public abstract class Factory : MonoBehaviour
    {
        public abstract IEnemy GetProduct(Vector3 position);
    }
}

