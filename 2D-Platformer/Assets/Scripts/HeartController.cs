using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{
    [SerializeField] private float health;
    [SerializeField] private Animator heartAnimator;

    private bool isTaken;
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == 11)
        {
            if (!isTaken)
            {
                other.gameObject.GetComponent<Health>().Healing(health);
                isTaken = true;
            }
            heartAnimator.SetBool("isTaken", isTaken);
            Destroy(gameObject,1f);
        }
    }
}
