using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{
   SpriteRenderer spriteRenderer;


   void Start() 
   {
      spriteRenderer = GetComponent<SpriteRenderer>();
   }




    private void OnTriggerEnter2D(Collider2D other) 
    {
      if(other.tag == "Enemy")
       {
          
          Time.timeScale =0;
          
       }
    }
}
