using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{   

    public Vector2 playerMovementDirections;
    
    private void Update() {
        HandlePlayerMovementInputs();
    }


    private void HandlePlayerMovementInputs() {
        playerMovementDirections.x = Input.GetAxis("Horizontal");
        playerMovementDirections.y = Input.GetAxis("Vertical");
    }
}
