
namespace SimpleFactoryPattern
{
     public interface IEnemy
           { 
               void Attack();
               void Move();
           }
           
           public class Zombie:IEnemy
           {
               public void Attack()
               {
               }
       
               public void Move()
               {
               }
           }
           
           public class Ghost:IEnemy
           {
              
               public void Attack()
               {
               }
       
               public void Move()
               {
               }
           }
       
           public class EnemyFactory
           {
               public IEnemy CreateEnemy(string enemy)
               {
                   switch (enemy.ToLower())
                   {
                       case "zombie":
                           return new Zombie();
                       case "ghost":
                           return new Ghost();
                       default:
                           return null;
                   }
               }
           }
           
           public class FactoryProvider
           {
               public void Main()
               {
                   EnemyFactory enemyFactory = new EnemyFactory();
                   enemyFactory.CreateEnemy("zombie").Move();
                   enemyFactory.CreateEnemy("Ghost").Attack();
               }
           }
}

