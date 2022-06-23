using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShotController : MonoBehaviour
{
  public GameObject bullet;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
      {
        shot();
      }
    }




    private void shot()
    {
        Instantiate(bullet,transform.position,Quaternion.identity);
    }

}
