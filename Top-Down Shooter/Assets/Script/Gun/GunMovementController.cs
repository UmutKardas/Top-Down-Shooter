using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovementController : MonoBehaviour
{
    public Vector3 mousePos;
    private Vector3 targetDirection;
    private float gunRotateZ;



    void Update()
    {
      GetMousePosition();
      GetGunRotate();
      
    }



    private void GetMousePosition()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            Input.mousePosition.y,  
            transform.position.z
        ));
    }


    private void GetGunRotate()
    {
      targetDirection = mousePos- transform.position;
      gunRotateZ = Mathf.Atan2(targetDirection.y,targetDirection.x)* Mathf.Rad2Deg;
      transform.rotation = Quaternion.Euler(0f, 0f, gunRotateZ);
    }


}
