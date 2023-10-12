using UnityEngine;

namespace Gun.WeaponParts
{
    public class Muzzle : WeaponPart
    {
        [SerializeField] private int damageModifier;
        [SerializeField] private float accuracyModifier;
        
        public override Weapon.ShootData Shoot(Weapon.ShootData data)
        {
            data.damage += damageModifier;
            data.accuracy += accuracyModifier;
            
            return data;
        }
    }
}
