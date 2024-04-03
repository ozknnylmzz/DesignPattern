using UnityEngine;

namespace DesignPattern
{
    public class FactoryGhost : Factory
    {
        [SerializeField] private Ghost _ghostPrefab;

        public override IEnemy GetProduct(Vector3 position)
        {
            GameObject intance = Instantiate(_ghostPrefab.gameObject, position, Quaternion.identity);
            Ghost ghost = intance.GetComponent<Ghost>();
            ghost.Initialize();
            return ghost;
        }
    }
}
