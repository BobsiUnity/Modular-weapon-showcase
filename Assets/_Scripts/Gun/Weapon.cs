using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gun
{
    public class Weapon : MonoBehaviour
    {
        public ShootData WeaponStats;

        [Header("Weapon parts")] [SerializeField]
        private List<WeaponPart> bodyPrefabs = new List<WeaponPart>();

        [SerializeField] private List<WeaponPart> stockPrefabs = new List<WeaponPart>();
        [SerializeField] private List<WeaponPart> scopePrefabs = new List<WeaponPart>();
        [SerializeField] private List<WeaponPart> pistolGripPrefabs = new List<WeaponPart>();
        [SerializeField] private List<WeaponPart> forwardGripPrefabs = new List<WeaponPart>();
        [SerializeField] private List<WeaponPart> handguardPrefabs = new List<WeaponPart>();
        [SerializeField] private List<WeaponPart> muzzlePrefabs = new List<WeaponPart>();

        private List<WeaponPart> weaponParts = new List<WeaponPart>();

        private void Awake()
        {
            SetupWeapon();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
                SetupWeapon();
        }

        private void SetupWeapon()
        {
            foreach (Transform part in transform)
                Destroy(part.gameObject);
            weaponParts.Clear();

            weaponParts.Add(Instantiate(bodyPrefabs.GetRandom(), transform));
            weaponParts.Add(Instantiate(stockPrefabs.GetRandom(), transform));
            weaponParts.Add(Instantiate(scopePrefabs.GetRandom(), transform));
            weaponParts.Add(Instantiate(muzzlePrefabs.GetRandom(), transform));
            weaponParts.Add(Instantiate(handguardPrefabs.GetRandom(), transform));
            weaponParts.Add(Instantiate(forwardGripPrefabs.GetRandom(), transform));
            weaponParts.Add(Instantiate(pistolGripPrefabs.GetRandom(), transform));

            SetWeaponStats();
        }

        private void SetWeaponStats()
        {
            ShootData data = new ShootData();
            foreach (WeaponPart part in weaponParts)
                data = part.Shoot(data);
            WeaponStats = data;
        }

        [System.Serializable]
        public struct ShootData
        {
            public int damage;
            public float recoil;
            public float accuracy;
        }
    }

    public abstract class WeaponPart : MonoBehaviour
    {
        public abstract Weapon.ShootData Shoot(Weapon.ShootData data);
    }
}
