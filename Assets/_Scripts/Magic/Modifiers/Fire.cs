using System.Collections;
using System.Collections.Generic;
using Magic;
using Unity.Mathematics;
using UnityEngine;

namespace Magic.Modifiers
{
    public class Fire : MagicModifier
    {
        [SerializeField] private int damageModifier;
        [SerializeField] private float speedModifier;
        
        [SerializeField] private ParticleSystem projectileFireEffect;
        [SerializeField] private ParticleSystem staffFireEffect;
        
        public override void Modify(Projectile projectile)
        {
            var baseDamage = projectile.BaseDamage;
            baseDamage.damage += damageModifier;
            projectile.BaseDamage = baseDamage;
            
            projectile.speed += speedModifier;
        }

        public override void Attach(Projectile projectile)
        {
            Transform projectileTransform = projectile.transform;
            Instantiate(projectileFireEffect, projectileTransform.position, projectileTransform.rotation, projectileTransform);
        }
        
        public override void AddStaffEffect(Transform staffOrb)
        {
            Instantiate(staffFireEffect, staffOrb.position, quaternion.identity, staffOrb);
        }
    }
}
