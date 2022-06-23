using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] enemyTransforms ;
    public float interval;
    void Start()
    {
        InvokeRepeating("EnemySpawn",0.5f ,interval);
    }

    private void EnemySpawn()
    {
        int randomPosition = Random.Range(0, enemyTransforms.Length);
        GameObject newEnemy =Instantiate(enemyPrefab,enemyTransforms[randomPosition].position,Quaternion.identity);

    }

   
}
