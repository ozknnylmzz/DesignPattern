using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Unity.VisualScripting.FullSerializer;

namespace DesignPattern.Mvp
{
    [RequireComponent(typeof(Health))]
    [RequireComponent(typeof(Slider))]
    public class HealthPresenter : MonoBehaviour
    {
        [SerializeField] private Health _health;

        [SerializeField] private Slider _slider;
        // Start is called before the first frame update
        void Start()
        {
            _slider.maxValue = 5;
        }

        private void OnEnable()
        {
            _health.OnChangeHealth += HealthChange;
        }

        private void HealthChange()
        {
            
            
            // _slider.DOValue(_health.CurrentHealth)
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}

