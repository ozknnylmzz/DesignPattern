using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern.Buiilder
{
    public class Director : MonoBehaviour
    {
        public static Action<int> OnSetModel;
        public static Action<int> OnSetGlass;
        private void Awake()
        {
            
        }

        private void OnEnable()
        {
            OnSetGlass = new Action<int>(SetGlass);
        }


        private void SetGlass(int glassIndex)
        {
            //if (_wheels != null
            //{
            //    Destroy(_wheels);
            //}

            //_wheels = Instantiate(_selectedCar.CarBuilderData.CarBuilder.Glass[glassIndex]);
        }
        
    }
}