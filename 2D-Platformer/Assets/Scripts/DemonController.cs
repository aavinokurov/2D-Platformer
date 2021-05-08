using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonController : MonoBehaviour
{
    [SerializeField] private Animator demonAnimator;
    [SerializeField] private float timeToAttack;
    [SerializeField] private Weapon weapon;
    [SerializeField] private StartAttack startAttack;

    private const float DEMON_IDEL = 0;
    private const float DEMON_ATTACK = 1;

    private float currentState;
    private float currentTimeToAttack;
    
    private void Start()
    {
        currentState = DEMON_IDEL;
        currentTimeToAttack = 0;
    }

    private void Update()
    {
        if (startAttack.startAttack)
        {
            if (currentTimeToAttack >= timeToAttack)
            {
                currentState = DEMON_ATTACK;
            }
            
            switch (currentState)
            {
                case DEMON_IDEL:
                    currentTimeToAttack += Time.deltaTime;
                    break;
                case DEMON_ATTACK:
                    demonAnimator.SetBool("isAttack", true);
                    Invoke(nameof(StartAttack),0.6f);
                    Invoke(nameof(StopAttack), 1f);
                    break;
            }
        }
    }

    public void StartAttack()
    {
        weapon.Attack();
    }

    private void StopAttack()
    {
        demonAnimator.SetBool("isAttack", false);
        currentTimeToAttack = 0;
        currentState = DEMON_IDEL;
    }
}
