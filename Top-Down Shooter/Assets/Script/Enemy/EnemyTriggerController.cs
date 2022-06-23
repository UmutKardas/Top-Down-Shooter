using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerController : MonoBehaviour
{
    [SerializeField] private EnemyDataTransmitter enemyDataTransmitter;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Bullet")) {
            enemyDataTransmitter.DecreaseEnemyHealt();
            Destroy(other.gameObject);
        }
    }

    
}
