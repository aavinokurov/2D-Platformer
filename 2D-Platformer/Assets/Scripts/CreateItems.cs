using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItems : MonoBehaviour
{
    [SerializeField] private GameObject item;
    [SerializeField] private Transform createPosition;
    [SerializeField] private Health healthEnemy;

    private void Update()
    {
        if (!healthEnemy.isAlive)
        {
            Instantiate(item,createPosition.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
