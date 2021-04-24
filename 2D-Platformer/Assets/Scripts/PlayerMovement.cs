using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Movement vars")]
    [SerializeField] private float jumpForce = 3;
    [SerializeField] private float speed = 3;
    [SerializeField] private bool isGround = false;

    [Header("Settings")]
    [SerializeField] private Transform groundColiderTransform;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float jumpOffSet;
    [SerializeField] private LayerMask groundMask;

    [Header("Rigidbody")]
    [SerializeField] private Rigidbody2D rigidbodyHero;

    private void FixedUpdate()
    {
        Vector3 overlapCircelTransform = groundColiderTransform.position;
        isGround = Physics2D.OverlapCircle(overlapCircelTransform, jumpOffSet, groundMask);
    }

    public void Move(float direction, bool isJump)
    {
        if (isJump)
        {
            Jump();
        }

        if (Mathf.Abs(direction) > 0.01f)
        {
            HorizontalMove(direction);
        }
    }

    private void Jump()
    {
        if(isGround)
        {
            rigidbodyHero.velocity = new Vector2(rigidbodyHero.velocity.x, jumpForce);
        }
            
    }

    private void HorizontalMove(float direction)
    {
        rigidbodyHero.velocity = new Vector2(curve.Evaluate(direction), rigidbodyHero.velocity.y);
    }
}
