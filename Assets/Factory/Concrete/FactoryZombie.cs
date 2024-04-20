
using UnityEngine;

namespace DesignPattern
{
    public class FactoryZombie : Factory
    {
        [SerializeField] private Zombie _zombiePrefab;

        public override IEnemy GetProduct(Vector3 position)
        {
            GameObject intance = Instantiate(_zombiePrefab.gameObject, position, Quaternion.identity);
            Ghost ghost = intance.GetComponent<Ghost>();
            ghost.Initialize();
            return ghost;
        }
    }
}

