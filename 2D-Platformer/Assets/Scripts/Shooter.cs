using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float fireSpeed;
    [SerializeField] private Transform firePointRight;
    [SerializeField] private Transform firePointLeft;
    [SerializeField] private SpriteRenderer spriteRendererBullet;

    public void Shoot(float direction)
    {
        if (direction >= 0)
        {
            GameObject currentBullet = Instantiate(bullet,firePointRight.position,Quaternion.identity);
            Rigidbody2D currentBulletRigidbody2D = currentBullet.GetComponent<Rigidbody2D>();
            spriteRendererBullet.flipX = true;
            currentBulletRigidbody2D.velocity = new Vector2(fireSpeed * 1, currentBulletRigidbody2D.velocity.y);
        }
        else
        {
            GameObject currentBullet = Instantiate(bullet,firePointLeft.position,Quaternion.identity);
            Rigidbody2D currentBulletRigidbody2D = currentBullet.GetComponent<Rigidbody2D>();
            spriteRendererBullet.flipX = false;
            currentBulletRigidbody2D.velocity = new Vector2(fireSpeed * (-1), currentBulletRigidbody2D.velocity.y);
        }
    }
}
