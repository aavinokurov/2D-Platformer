using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject weaponCollider;

    public void Attack(bool Flag)
    {
        if (!weaponCollider.activeSelf && Flag)
        {
            weaponCollider.SetActive(true);
            StartCoroutine(AttackTimer());
        }
    }
    
    private IEnumerator AttackTimer()
    {
        yield return new WaitForSeconds(0.05f);
        
        weaponCollider.SetActive(false);
    }
}
