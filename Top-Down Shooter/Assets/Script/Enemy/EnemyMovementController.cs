using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    Transform enemyTransform;
    Transform playerPosition;
    public float speed ;
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyTransform = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }



    void Update()
    {
        SetEnemySpeed();
    }



    private void SetEnemySpeed()
    {
        
        transform.position = Vector2.MoveTowards(
        transform.position,
        playerPosition.position,
        speed*Time.deltaTime
        );

    }
}
