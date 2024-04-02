using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace FactoryMethodPattern 
{
    public class FactoryMethodProvider:MonoBehaviour
    {
        private ManageEnemyFactory _manageEnemyFactory = new ManageEnemyFactory();
        public const string Elf = "enemyElf";
        public const string Monster = "lavaMonster";
        public const string Zombie = "snowZombie";

        private void OnTriggerEnter(Collider other)
        {
            if (other.name==Elf)
            {
                _manageEnemyFactory.Create(Elf);
            }

            if (other.name==Monster)
            {
                _manageEnemyFactory.Create(Monster);
            }

            if (other.name==Zombie)
            {
                _manageEnemyFactory.Create(Zombie);
            }
        }
    }

    public interface IEnemy
    {
        void Move();
        void Attack();
    }
    
    public abstract class CreateFactory
    {
        public abstract IEnemy Create(string name);
    }
    
    public class ManageEnemyFactory:CreateFactory
    {
        public override IEnemy Create(string name)
        {
            switch (name.ToLower())
            {
                case FactoryMethodProvider.Elf:
                    return new ElfDefender();
                case FactoryMethodProvider.Monster:
                    return new LavaMonster();
                case FactoryMethodProvider.Zombie:
                    return new SnowZombie();
                default:
                    return null;
            }
        }
    }

    public class ElfDefender:IEnemy
    {
        public void Move()
        {
        }

        public void Attack()
        {
        }
    }
    public class LavaMonster:IEnemy
    {
        public void Move()
        {
        }

        public void Attack()
        {
        }
    }
    public class SnowZombie:IEnemy
    {
        public void Move()
        {
        }

        public void Attack()
        {
        }
    }
}

