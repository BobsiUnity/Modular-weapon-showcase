using UnityEngine;

namespace Gun.WeaponParts
{
    public class ForwardGrip : WeaponPart
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
