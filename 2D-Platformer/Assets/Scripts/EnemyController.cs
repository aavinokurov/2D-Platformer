using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeToRevert;
    [SerializeField] private Animator animatorEnemy;
    [SerializeField] private SpriteRenderer spriteEnemy;
    [SerializeField] private Rigidbody2D enemyRigidBody;
    [SerializeField] private Health healthEnemy;

    private const float IDEL_STATE = 0;
    private const float WALK_STATE = 1;
    private const float REVERT_STATE = 2;

    private float currenrState;
    private float currenrTimeToRevert;

    private void Start()
    {
        currenrState = WALK_STATE;
        currenrTimeToRevert = 0;
    }

    private void Update()
    {
        if (healthEnemy.isAlive)
        {
            if (currenrTimeToRevert >= timeToRevert)
            {
                currenrTimeToRevert = 0;
                currenrState = REVERT_STATE;
            }
            
            switch (currenrState)
            {
                case IDEL_STATE:
                    currenrTimeToRevert += Time.deltaTime;
                    animatorEnemy.SetBool("isShriek",true);
                    break;
                case WALK_STATE:
                    enemyRigidBody.velocity = Vector2.left * speed;
                    animatorEnemy.SetBool("isShriek",false);
                    animatorEnemy.SetBool("isIdel",true);
                    break;
                case REVERT_STATE:
                    spriteEnemy.flipX = !spriteEnemy.flipX;
                    speed *= -1;
                    currenrState = WALK_STATE;
                    break;
            }
        }
        else
        {
            animatorEnemy.SetBool("isDeath", true);
            Destroy(gameObject, 0.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EnemyStoper"))
        {
            currenrState = IDEL_STATE;
        }
    }
}
