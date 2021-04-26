using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private SpriteRenderer spriteHealth;

    private float currentHealth;
    public bool isAlive;

    private void Awake()
    {
        currentHealth = maxHealth;
        HealthImg();
        isAlive = true;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        HealthImg();
        CheckIsAlive();
    }

    private void HealthImg()
    {
        spriteHealth.size = new Vector2(currentHealth/maxHealth, spriteHealth.size.y);
    }

    private void CheckIsAlive()
    {
        if (currentHealth > 0)
        {
            isAlive = true;
        }
        else
        {
            isAlive = false;
        }
    }
}
