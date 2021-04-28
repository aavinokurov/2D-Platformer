using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class DeathHero : MonoBehaviour
{
    [SerializeField] private GameObject deathPanel;
    [SerializeField] private Health healthHero;
    private void OnTriggerEnter2D(Collider2D deathFloor)
    {
        if (deathFloor.CompareTag("Death"))
        {
            Death();
        }
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (!healthHero.isAlive)
        {
            Death();
        }
    }

    private void Death()
    {
        deathPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
