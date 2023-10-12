using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Magic
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private TextMeshPro damageText;
        
        public void TakeDamage(int damage)
        {
            var spawnedText = Instantiate(damageText, transform.position + Vector3.up * 0.6f + Vector3.right * Random.Range(-1f, 1f), Quaternion.LookRotation(Camera.main.transform.forward));
            spawnedText.text = damage.ToString();
            
            Sequence sequence = DOTween.Sequence();
            sequence.Append(spawnedText.transform.DOMoveY(spawnedText.transform.position.y + 5, 3));
            sequence.Append(spawnedText.transform.DOScale(Vector3.zero, 0.5f));
            sequence.AppendCallback(() => Destroy(spawnedText.gameObject));
        }
    }
}