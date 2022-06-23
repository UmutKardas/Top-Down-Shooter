using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDataTransmitter : MonoBehaviour
{
    [SerializeField] GunMovementController gunMovementController;
    [SerializeField] GunShotController gunShotController; 


    public Vector3 GetGunMovementValues  ()
    {
        return gunMovementController.mousePos;
    }
    
}
