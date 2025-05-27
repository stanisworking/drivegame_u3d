using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
    public Vector2 moveSpeed;

    public Rigidbody2D body;

    public FloatSO currentFuel;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        var moveAction = InputSystem.actions.FindAction("Move");  
        var moveValue = moveAction.ReadValue<Vector2>();

        if (currentFuel.value <= 0)
        {
            moveSpeed.x = 0;
        }
        
        body.AddForce(Vector2.Scale(moveValue, moveSpeed));
    }

}
