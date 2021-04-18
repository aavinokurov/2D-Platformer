using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbodyHero;

    [SerializeField] private float jumpForce = 3;

    private void FixedUpdate()
    {
        
    }

    public void Move(float direction, bool isJump)
    {
        if (isJump)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rigidbodyHero.velocity = new Vector2(rigidbodyHero.velocity.x, jumpForce);
    }
}
