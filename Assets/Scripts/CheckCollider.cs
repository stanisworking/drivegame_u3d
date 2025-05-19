using UnityEngine;
using UnityEngine.Events;

public class CheckCollider : MonoBehaviour
{
    public Collider2D checkCollider;

    public UnityEvent onCollisionEnter;
    public UnityEvent onCollisionExit;

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider == checkCollider) {
            onCollisionEnter.Invoke();
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if(other.collider == checkCollider) {
            onCollisionExit.Invoke();
        }
    }

}
