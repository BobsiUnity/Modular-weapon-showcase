using UnityEngine;

namespace Gun.WeaponParts
{
    public class PistolGrip : WeaponPart
    {
        [SerializeField] private float recoilModifier, accuracyModifier;
        
        public override Weapon.ShootData Shoot(Weapon.ShootData data)
        {
            data.recoil += recoilModifier;
            data.accuracy += accuracyModifier;
            
            return data;
        }
    }
}
