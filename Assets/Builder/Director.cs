using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace DesignPattern.Buiilder
{
    public class Director : MonoBehaviour
    {
        [SerializeField] private  GameObject[] _models;
        [SerializeField] private  GameObject[] _wheels;
        [SerializeField] private GameObject[] _glasses;
        public GameObject[] Models => _glasses;
        public GameObject[] Wheels => _wheels;
        public GameObject[] Glasses => _glasses;
        
        private GameObject _selectedModel;
        private GameObject _selectedWheel;
        private GameObject _selectedGlass;


        private void Start()
        {
            SetModel(0);
        }

        public void SetModel(int modelIndex)
        {
            if (_selectedModel!=null)
            {
                Destroy(_selectedModel);
            }
            
            _selectedModel = Instantiate(_models[modelIndex]);
            _selectedWheel = Instantiate(_wheels[modelIndex],_selectedModel.transform);
            _selectedGlass = Instantiate(_glasses[modelIndex],_selectedModel.transform);
            
            new CarBuilder(_selectedModel).WithGlass(_selectedWheel).WithWheel(_selectedGlass).Build();
        }

        public void SetGlass(int glassIndex)
        {
            if (glassIndex>Glasses.Length || glassIndex < 0) { return; }

            Destroy(_selectedGlass);
            
            _selectedGlass = Instantiate(Glasses[glassIndex],_selectedModel.transform);

        }
        public void SetWheel(int wheelIndex)
        {
            if (wheelIndex>Wheels.Length || wheelIndex < 0) { return; }

            Destroy(_selectedWheel);
            
            _selectedWheel = Instantiate(Wheels[wheelIndex],_selectedModel.transform);

        }
        
    }
}