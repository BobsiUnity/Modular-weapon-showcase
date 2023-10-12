using UnityEngine;

namespace Gun.WeaponParts
{
    public class Body : WeaponPart
    {
        [SerializeField] private int damageModifier;
        
        public override Weapon.ShootData Shoot(Weapon.ShootData data)
        {
            data.damage += damageModifier;
            
            return data;
        }
    }
}
