using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAttack : MonoBehaviour
{
    public bool startAttack;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 11)
        {
            startAttack = true;
        }
    }
}
