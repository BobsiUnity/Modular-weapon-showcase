using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Magic
{
    public abstract class MagicModifier : MonoBehaviour
    {
        public void Shoot(Projectile projectile)
        {
            Modify(projectile);
            Attach(projectile);
        }

        /// <summary>
        /// Modify the stats of the projectile
        /// </summary>
        /// <param name="projectile">The instantiated projectile to modify</param>
        public abstract void Modify(Projectile projectile);
        
        /// <summary>
        /// Attach any components or effects to the projectile
        /// </summary>
        /// <param name="projectile">The instantiated projectile to modify</param>
        public abstract void Attach(Projectile projectile);

        /// <summary>
        /// Add an effect to the staff when the modifier is added
        /// </summary>
        /// <param name="staffOrb">The transform of the staffs magic orb</param>
        public abstract void AddStaffEffect(Transform staffOrb);
    }
}
