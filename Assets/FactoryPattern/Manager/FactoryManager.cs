
using System.Collections.Generic;
using UnityEngine;

namespace DesignPattern
{
    public class FactoryManager : PersistenceSingleton<FactoryManager>
    {
       private static Dictionary<string, Factory> _factories = new ();
       
       public static void RegisterFactory(string enemyType, Factory factory)
       {
           if (!_factories.ContainsKey(enemyType))
           {
               _factories.Add(enemyType, factory);
           }
       }
       
       public static IEnemy GetEnemy(string enemyType, Vector3 position)
       {
           if (_factories.ContainsKey(enemyType))
           {
               return _factories[enemyType].GetProduct(position);
           }
           
           return null;
       }
    }
    
 
}

