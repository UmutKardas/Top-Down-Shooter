using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealtController : MonoBehaviour
{

    [SerializeField]  private EnemyDataTransmitter enemyDataTransmitter;
    public int healt = 3;
    
    void Update()
    {
        EnemyDestroy();
    }



    public void EnemyHealtDown(int value)
    {
        healt -= value;

    }

    
    private void EnemyDestroy()
    {
        if (healt <= 0)
        {
            Destroy(gameObject);
        }
    }
}
