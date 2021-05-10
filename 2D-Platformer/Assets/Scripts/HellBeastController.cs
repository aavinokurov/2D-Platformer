using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellBeastController : MonoBehaviour
{
    [SerializeField] private float timeToAttack;
    [SerializeField] private Animator animatorEnemy;
    [SerializeField] private bool direction;
    [SerializeField] private SpriteRenderer spriteRendererEnemy;
    [SerializeField] private Shooter enemyShooter;
    [SerializeField] private Health enemyHealt;

    private const float IDEL_STATE = 0;
    private const float FIRE_STATE = 1;

    private float currentTimeToAttack;
    private float currentState;

    private void Start()
    {
        currentState = IDEL_STATE;
        currentTimeToAttack = 0;
        spriteRendererEnemy.flipX = direction;
    }

    private void Update()
    {
        if (enemyHealt.isAlive)
        {
            if (currentTimeToAttack >= timeToAttack)
            {
                currentState = FIRE_STATE;
                currentTimeToAttack = 0;
            }
            
            switch (currentState)
            {
                case IDEL_STATE:
                    currentTimeToAttack += Time.deltaTime;
                    break;
                case FIRE_STATE:
                    animatorEnemy.SetBool("isAttack", true);
                    currentState = IDEL_STATE;
                    Invoke(nameof(Attack),0.6f);
                    break;
            }
        }
        else
        {
            animatorEnemy.SetBool("isDeath", true);
            Destroy(gameObject,0.5f);
        }
    }

    private void Attack()
    {
        animatorEnemy.SetBool("isAttack", false);
        float directionFire = direction ? 0.1f : -0.1f;
        enemyShooter.Shoot(directionFire);
    }
}
