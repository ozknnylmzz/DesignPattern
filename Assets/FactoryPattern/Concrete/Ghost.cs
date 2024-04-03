using UnityEngine;
using UnityEngine.Serialization;

namespace DesignPattern
{
    public class Ghost : MonoBehaviour, IEnemy
    {
        [SerializeField] private string _productName = "Ghost";

        public string ProductName
        {
            get => _productName;
            set => ProductName = value;
        }

        public void Initialize()
        {
            gameObject.name = _productName;
            Attack();
        }

        public void Attack()
        {
            Debug.Log("Dealt 8 damage");
        }
    }
}