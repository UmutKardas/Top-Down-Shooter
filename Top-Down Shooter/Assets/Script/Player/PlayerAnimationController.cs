using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    [SerializeField] private PlayerDataTransmitter playerDataTransmitter;
    public Animator Animator;
    

    void Update()
    {
        SetPlayerRunAnimation();
    }
    


 
    private void SetPlayerRunAnimation()
    {
        if (playerDataTransmitter.GetPlayerInputValues().x !=0 || playerDataTransmitter.GetPlayerInputValues().y !=0 )
        {
            Animator.SetBool("running",true);
        }
        else
        {
            Animator.SetBool("running",false);
        }
    }
}
