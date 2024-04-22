using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern.Buiilder
{
    public class CarBuild:MonoBehaviour
    {
        public GameObject Car;
        public GameObject[] Wheels;
        public GameObject[] Glasses;
   
        public void AddWheels(int type, GameObject wheel)
        {
            Instantiate(Wheels[type], wheel.transform);
        }
   
        public void AddGlasses(int type, GameObject glass)
        {
            Instantiate(Glasses[type], glass.transform);
        }

        public GameObject GetCar()
        {
            return gameObject;
        }
    }
}

