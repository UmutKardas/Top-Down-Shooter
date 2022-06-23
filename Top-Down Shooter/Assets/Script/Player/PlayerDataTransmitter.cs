using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataTransmitter : MonoBehaviour
{
    [SerializeField] private PlayerMovementController playerMovementController;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private PlayerAnimationController playerAnimationController;
    [SerializeField] private PlayerCollisionController playerCollisionController;
    

 
    public Vector2 GetPlayerInputValues() {
        return playerInputController.playerMovementDirections;
    }



    
    public Animator GetPlayerAnimationValues()
    {
        return playerAnimationController.Animator;
    }
}
