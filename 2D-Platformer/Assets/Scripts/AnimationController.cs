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
}
