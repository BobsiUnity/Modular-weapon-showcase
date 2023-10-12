using UnityEngine;

namespace Gun.WeaponParts
{
    public class Stock : WeaponPart
    {
        [SerializeField] private float recoilModifier;
        
        public override Weapon.ShootData Shoot(Weapon.ShootData data)
        {
            data.recoil += recoilModifier;
            
            return data;
        }
    }
}
