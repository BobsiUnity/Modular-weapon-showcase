using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magic
{
    public class DamageOverTime : EnemyModifier
    {
        public int damage;
        public float tickRate;
        public int tickAmount;
    
        private float _lastTickTime;

        public override void Initialized()
        {
            _lastTickTime = Time.time;
        }

        public override void ModifierUpdate()
        {
            if (_lastTickTime + tickRate < Time.time)
            {
                _lastTickTime = Time.time;
                tickAmount--;
                DealDamage();

                if (tickAmount <= 0)
                    Destroy(this);
            }
        }

        private void DealDamage()
        {
            enemyHealth.TakeDamage(damage);
        }
    }
}

