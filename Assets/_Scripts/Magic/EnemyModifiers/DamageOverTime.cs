using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magic.Modifiers
{
    [Serializable]
    public struct DamageOverTime : IEnemyModifier
    {
        public int damage;
        public float tickRate;
        public int tickAmount;
    
        private float _lastTickTime;
        
        public void Initialized()
        {
            _lastTickTime = Time.time;
        }

        public bool ModifierUpdate(Health _enemyHealth)
        {
            if (_lastTickTime + tickRate < Time.time)
            {
                _lastTickTime = Time.time;
                tickAmount--;
                DealDamage(_enemyHealth);

                if (tickAmount <= 0)
                    return false;
            }
            
            return true;
        }

        private void DealDamage(Health _enemyHealth)
        {
            _enemyHealth.TakeDamage(damage);
        }
    }
    
    [Serializable]
    public struct InstantDamage : IEnemyModifier
    {
        public int damage;
    
        public void Initialized() {}

        public bool ModifierUpdate(Health _enemyHealth)
        {
            _enemyHealth.TakeDamage(damage);
            return false;
        }
    }
}

