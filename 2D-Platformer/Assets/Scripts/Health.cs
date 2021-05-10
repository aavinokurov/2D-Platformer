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
        if (isAlive)
        {
            currentHealth -= damage;
            HealthImg();
            CheckIsAlive();
        }
    }

    public void Healing(float health)
    {
        if (currentHealth < maxHealth)
        {
            currentHealth += health;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
            HealthImg();
        }
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
