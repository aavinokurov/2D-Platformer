using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private Weapon weapon;
    [SerializeField] private AnimationController animationHero;

    private void FixedUpdate()
    {
        if (!StartCutscene.isCutsceneOn)
        {
            float horizontalDirection = Input.GetAxis(GlobalStringVars.HORIZONTAL_AXIS);
            bool isJumpButtonPressed = Input.GetButtonDown(GlobalStringVars.JUMP);
            playerMovement.Move(horizontalDirection, isJumpButtonPressed);
    
            bool isAttack = Input.GetButtonDown(GlobalStringVars.FIRE_1);
            weapon.Attack(isAttack);
            animationHero.AttackAnimation(isAttack);
        }

    }
}
