using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameController : MonoBehaviour
{
    [SerializeField] private Transform hero;

    private void Update()
    {
        if (hero.position.x > 0 && hero.position.x < 17.8)
        {
            transform.position = new Vector3(hero.position.x, transform.position.y, transform.position.z);
        }
    }
}
