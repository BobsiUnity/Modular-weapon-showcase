using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magic
{
    public abstract class EnemyModifier : MonoBehaviour
    {
        [HideInInspector] public Health enemyHealth;

        private bool _isAttached = false;

        private void Awake()
        {
            if (TryGetComponent(out Health health))
                enemyHealth = health;
            else
                Debug.LogError("EnemyModifier needs a Health component on the same GameObject", this);

            Initialized();
            _isAttached = true;
        }

        public void Update()
        {
            if (!_isAttached)
                return;

            ModifierUpdate();
        }

        /// <summary>
        /// Called when the modifier is added to an enemy and initialized
        /// </summary>
        public abstract void Initialized();

        /// <summary>
        /// This is the update method for the modifier
        /// </summary>
        public abstract void ModifierUpdate();
    }
}