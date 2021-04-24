using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(Shooter))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private Shooter shooter;

    private void FixedUpdate()
    {
        float horizontalDirection = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
        bool isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars.JUMP);

        if(Input.GetButtonDown(GlobalStringVars.FIRE_1))
        {
            shooter.Shoot(horizontalDirection);
        }

        playerMovement.Move(horizontalDirection, isJumpButtonPressed);
    }
}
