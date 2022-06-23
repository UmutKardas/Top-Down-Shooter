using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Vector2 target;

    public float lifeTime;
    public float speed;

    void Start()
    {
        target= Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    // Update is called once per frame
    void Update()
    {
       GetBulletTransform();
       DestoyBullet();

    }

    private void GetBulletTransform()
    {
         transform.position = Vector2.MoveTowards(
            transform.position,
            target,
            speed*Time.deltaTime
        );
    }
    

    private void DestoyBullet() {
        Destroy(gameObject, lifeTime);
    }
}
