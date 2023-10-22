using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magic
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private Projectile projectilePrefab;
        [SerializeField] private Transform staffOrb;
        
        [SerializeField] private List<MagicModifier> modifiers;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                Fire();
        }

        private void Fire()
        {
            var projectile = Instantiate(projectilePrefab, staffOrb.position, staffOrb.rotation);
            foreach (var magicModifier in modifiers)
                magicModifier.Shoot(projectile);
        }

        public void AddModifier(MagicModifier modifier)
        {
            modifiers.Add(modifier);
            modifier.AddStaffEffect(staffOrb);
        }
        
        //This is purely for testing of adding modifiers
        [SerializeField] private MagicModifier modifierToAdd;

        [EButton("Add Modifier")]
        private void AddTempModifier()
        {
            if (modifierToAdd == null)
                return;
            AddModifier(modifierToAdd);
            modifierToAdd = null;
        }

        [EButton("Clear Modifiers")]
        private void ClearModifiers()
        {
            modifiers.Clear();
            foreach (Transform child in staffOrb)
                Destroy(child.gameObject);
        }
    }
}
