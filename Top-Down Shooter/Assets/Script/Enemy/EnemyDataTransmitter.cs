using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDataTransmitter : MonoBehaviour
{
   
    [SerializeField] private EnemyMovementController enemyMovementController;
    [SerializeField] private EnemyTriggerController enemyTriggerController;
    [SerializeField] private EnemyHealtController enemyHealtController;


    public Transform GetEnemyMovementValues ()
    {
        return enemyMovementController.transform;
    }


    public void DecreaseEnemyHealt() {
        enemyHealtController.EnemyHealtDown(1);
    }
}
