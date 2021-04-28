using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonCollision : MonoBehaviour
{
    [SerializeField] private float damage;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 11)
        {
            other.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
