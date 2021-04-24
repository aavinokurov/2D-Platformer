using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireSpeed;
    [SerializeField] private Transform firePoint;

    public void Shoot(float direction)
    {
        GameObject currentBullet = Instantiate(bullet,firePoint.position,Quaternion.identity);
        Rigidbody2D currentBulletRigidbody2D = currentBullet.GetComponent<Rigidbody2D>();

        if (direction >= 0)
        {
            currentBulletRigidbody2D.velocity = new Vector2(fireSpeed * 1, currentBulletRigidbody2D.velocity.y);
        }
        else
        {
            currentBulletRigidbody2D.velocity = new Vector2(fireSpeed * (-1), currentBulletRigidbody2D.velocity.y);
        }
    }
}
