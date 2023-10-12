using UnityEngine;

namespace Gun.WeaponParts
{
    public class Scope : WeaponPart
    {
        [SerializeField] private float accuracyModifier;
        
        public override Weapon.ShootData Shoot(Weapon.ShootData data)
        {
            data.accuracy += accuracyModifier;
            
            return data;
        }
    }
}
