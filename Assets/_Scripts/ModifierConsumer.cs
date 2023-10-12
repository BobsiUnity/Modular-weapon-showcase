using System.Collections.Generic;
using Magic;
using UnityEngine;

public class ModifierConsumer : MonoBehaviour
{
    [SerializeField] private Health m_health;

    readonly List<IEnemyModifier> m_enemyModifiers = new ();
    
    public void ConsumeModifier(IEnemyModifier modifier)
    {
#if UNITY_EDITOR
        if (!modifier.GetType().IsValueType)
            throw new System.Exception("Modifier is not a value type");
#endif
        
        modifier.Initialized();
        m_enemyModifiers.Add(modifier);
    }

    private void Update()
    {
        for (int i = 0; i < m_enemyModifiers.Count; i++)
        {
            if (!m_enemyModifiers[i].ModifierUpdate(m_health))
                m_enemyModifiers.RemoveAt(i--);
        }
    }
}
