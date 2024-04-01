using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FactorySimplePattern
{
     public interface IEnemy
           { 
               float Ability { get; }
               float Health { get; }
               void Attack();
               void Move();
           }
           
           public class Zombie:IEnemy
           {
               public float Ability { get; private set; }
               public float Health { get; }
               public void Attack()
               {
                   throw new System.NotImplementedException();
               }
       
               public void Move()
               {
                   throw new System.NotImplementedException();
               }
           }
           
           public class Ghost:IEnemy
           {
               public float Ability { get; }
               public float Health { get; }
               public void Attack()
               {
                   throw new System.NotImplementedException();
               }
       
               public void Move()
               {
                   throw new System.NotImplementedException();
               }
           }
       
           public class EnemyFactory
           {
               public IEnemy CreateEnemy(string enemy)
               {
                   switch (enemy)
                   {
                       case "Zombie":
                           return new Zombie();
                       case "Ghost":
                           return new Ghost();
                       default:
                           return null;
                   }
               }
           }
           
           public class Main
           {
               public void Mains()
               {
                   EnemyFactory enemyFactory = new EnemyFactory();
                   enemyFactory.CreateEnemy("zombie").Move();
               }
           }
}

