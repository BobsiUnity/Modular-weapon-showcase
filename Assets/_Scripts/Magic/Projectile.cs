using System.Collections.Generic;
using Magic.Modifiers;
using UnityEngine;

namespace Magic
{
    public class Projectile : MonoBehaviour
    {
        public float speed;

        [SerializeField] private float lifeTime = 5;
        private Transform _transform;

        private readonly List<IEnemyModifier> _enemyModifiers = new ();

        public InstantDamage BaseDamage;

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
            if (other.TryGetComponent(out ModifierConsumer consumer))
            {
                consumer.ConsumeModifier(BaseDamage);
                
                for (var i = 0; i < _enemyModifiers.Count; i++)
                {
                    var mod = _enemyModifiers[i];
                    consumer.ConsumeModifier(mod);
                }

                Destroy(gameObject);
            }
        }

        public void AddEnemyModifier(IEnemyModifier modifier)
        {
            _enemyModifiers.Add(modifier);
        }
    }
}
