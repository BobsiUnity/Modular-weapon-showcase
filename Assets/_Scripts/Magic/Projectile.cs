using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Magic
{
    public class Projectile : MonoBehaviour
    {
        public int damage;
        public float speed;

        [SerializeField] private float lifeTime = 5;
        private Transform _transform;

        private List<EnemyModifier> _enemyModifiers = new List<EnemyModifier>();

        private void Awake()
        {
            _transform = transform;
        }

        private void Update()
        {
            lifeTime -= Time.deltaTime;
            if(lifeTime < 0)
                Destroy(gameObject);

            _transform.position += _transform.forward * (speed * Time.deltaTime);
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Health health))
            {
                health.TakeDamage(damage);
                SetEnemyModifiers(health.gameObject);
                Destroy(gameObject);
            }
        }

        private void SetEnemyModifiers(GameObject enemy)
        {
            foreach (var modifier in _enemyModifiers)
            {
                enemy.AddComponent(modifier.GetType());
            }
            
            _enemyModifiers.Clear();
        }

        public void AddEnemyModifier(EnemyModifier modifier)
        {
            _enemyModifiers.Add(modifier);
        }
    }
}
