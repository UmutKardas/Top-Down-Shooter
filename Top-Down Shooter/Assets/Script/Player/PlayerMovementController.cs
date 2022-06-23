using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;

    [SerializeField] private Rigidbody2D rigid;


    [SerializeField] private float movementSpeed;




    void Update()
    {
        SetPlayerMovementSpeed();
    }



    private void SetPlayerMovementSpeed() {
        rigid.velocity = new Vector2(
            playerDataTransmitter.GetPlayerInputValues().x * movementSpeed * Time.deltaTime,
            playerDataTransmitter.GetPlayerInputValues().y * movementSpeed * Time.deltaTime
        );
    }
}
