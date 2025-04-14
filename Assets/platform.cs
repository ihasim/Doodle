
using UnityEngine;

public class Platform : MonoBehaviour     
{
    public float jumpForce = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 v = rb.linearVelocity;   
                v.y = jumpForce;         
                rb.linearVelocity = v;         
            }
        }
        
    }
}
