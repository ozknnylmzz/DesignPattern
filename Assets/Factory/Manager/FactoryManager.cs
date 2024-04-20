
using System;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class FactoryManager : PersistenceSingleton<FactoryManager>
    {
       private static Dictionary<string,Func<Factory>> _factories = new ();
       
       
       public static void RegisterFactory(string enemyType, Func<Factory> factory)
       {
           if (!_factories.ContainsKey(enemyType))
           {
               _factories.Add(enemyType, factory);
           }
       }
       
       public static IEnemy GetEnemy(string enemyType, Vector3 position)
       {
           if (_factories.TryGetValue(enemyType, out var factoryCreator))
           {
               Factory factory = factoryCreator.Invoke();
               return factory.GetProduct(position);
           }
           
           return null;
       }
    }
    
 
}

