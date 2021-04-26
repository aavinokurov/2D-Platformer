using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator heroAnimator;

    public void RunAnimation(bool Flag)
    {
        heroAnimator.SetBool("isRunning", Flag);
    }

    public void JumpAnimation(bool Flag)
    {
        heroAnimator.SetBool("isJumping", Flag);
    }

    public void AttackAnimation(bool Flag)
    {
        if (!heroAnimator.GetBool("isAttack") && Flag)
        {
            heroAnimator.SetBool("isAttack",true);

            StartCoroutine(AttackTimer());
        }
    }

    private IEnumerator AttackTimer()
    {
        yield return new WaitForSeconds(0.05f);
        
        heroAnimator.SetBool("isAttack",false);
    }
}
