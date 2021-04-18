using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullExplosion : MonoBehaviour
{
    [SerializeField] private GameObject demon;
    [SerializeField] private Transform parent;
    [SerializeField] private bool isDead;
    [SerializeField] private GameObject skull;
    [SerializeField] private GameObject skullFire;

    private void FixedUpdate()
    {
        if (isDead)
        {
            skull.SetActive(true);
            skullFire.SetActive(true);
            Destroy(demon);
            Instantiate(skull, parent);
            Instantiate(skullFire, parent);
            StartCoroutine(explosionTimer());
        }
    }

    private IEnumerator explosionTimer()
    {
        yield return new WaitForSeconds(0.1f);

        isDead = false;
        Destroy(gameObject, 0.5f);
    }
}
