using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern.Mvp
{
    public class Health : MonoBehaviour
    {
        public event Action OnChangeHealth;

        private const int _minHealth =0;
        private const int _maxHealth=100;
        
        private int _currentHealth;

        public int CurrentHealth { get=> _currentHealth ; private set => _currentHealth=value; }

        public void IncreaseHealth()
        {
            _currentHealth++;
            _currentHealth = Mathf.Max(_currentHealth,5);
            UpdateHealth();
        }
        
        public void DecraseHealth()
        {
            _currentHealth--;
            _currentHealth = Mathf.Min(_currentHealth,0);
            UpdateHealth();
        }

        public void UpdateHealth()
        {
            OnChangeHealth?.Invoke();
        }
    }
}

