using UnityEngine;

public class DamageDealler : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private bool destroy;

    private void OnTriggerEnter2D(Collider2D bullet)
    {
        if (bullet.CompareTag("Damageable"))
        {
            bullet.gameObject.GetComponent<Health>().TakeDamage(damage);
        }

        if (destroy)
        {
            Destroy(gameObject,0.5f);
        }
    }
}
