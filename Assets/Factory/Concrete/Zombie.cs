
using UnityEngine;

namespace DesignPattern
{
    public class Zombie :MonoBehaviour, IEnemy
    {
        [SerializeField] private string _productName = "Zombie";
        public string ProductName
        {
            get => _productName;
            set => ProductName = value;
        }

        public void Initialize()
        {
            gameObject.name = _productName;
        }

        public void Attack()
        {
            Debug.Log("Dealt 15 damage");
        }
    }
}

