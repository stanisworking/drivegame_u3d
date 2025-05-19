using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class MovingEnemy : MonoBehaviour
{
    // public Collider2D leftCheck;
    // public Collider2D rightCheck;

    public Vector2 speed;
    
    public Rigidbody2D body;

    // public LayerMask checkLayers;

    private void Start()
    {
        body.linearVelocityX = Random.Range(0, 2) == 0 ? speed.x : -speed.x;
        body.linearVelocityY = speed.y;
    }

    // private void FixedUpdate()
    // {
    //     if (leftCheck.IsTouchingLayers(checkLayers.value))
    //     {
    //         body.linearVelocityX = speed.x;
    //     }  
    //     else if (rightCheck.IsTouchingLayers(checkLayers.value))
    //     {
    //         body.linearVelocityX = -speed.x;
    //     }
    // }

    public void MoveRight() {
        body.linearVelocityX = speed.x;
        body.linearVelocityY = speed.y;
   }

    public void MoveLeft() {
        body.linearVelocityX = -speed.x;
        body.linearVelocityY = speed.y;        
    }
}
