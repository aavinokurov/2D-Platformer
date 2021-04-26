using UnityEngine;

public class DamageDealler : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D bullet)
    {
        if(bullet.CompareTag("Damageable"))
        {
            bullet.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
