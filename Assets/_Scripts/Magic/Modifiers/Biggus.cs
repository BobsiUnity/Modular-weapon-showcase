using System.Collections;
using System.Collections.Generic;
using Magic;
using Unity.Mathematics;
using UnityEngine;

namespace Magic.Modifiers
{
    public class Biggus : MagicModifier
    {
        [SerializeField] private float sizeModifier;
        
        public override void Modify(Projectile projectile)
        {
            projectile.transform.localScale *= sizeModifier;
        }

        public override void Attach(Projectile projectile)
        {
            
        }
        
        public override void AddStaffEffect(Transform staffOrb)
        {
            
        }
    }
}
