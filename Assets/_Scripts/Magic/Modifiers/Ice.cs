using System;
using System.Collections;
using System.Collections.Generic;
using Magic;
using Unity.Mathematics;
using UnityEngine;

namespace Magic.Modifiers
{
    public class Ice : MagicModifier
    {
        [SerializeField] private ParticleSystem projectileFireEffect;
        [SerializeField] private ParticleSystem staffFireEffect;

        [SerializeField] private DamageOverTime enemyModifier;

        public override void Modify(Projectile projectile)
        {
            
        }

        public override void Attach(Projectile projectile)
        {
            Transform projectileTransform = projectile.transform;
            Instantiate(projectileFireEffect, projectileTransform.position, projectileTransform.rotation, projectileTransform);
            projectile.AddEnemyModifier(enemyModifier);
        }
        
        public override void AddStaffEffect(Transform staffOrb)
        {
            Instantiate(staffFireEffect, staffOrb.position, quaternion.identity, staffOrb);
        }
    }
}
