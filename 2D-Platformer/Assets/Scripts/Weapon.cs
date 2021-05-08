using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject weaponCollider;
    [SerializeField] private float timeAttack;

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
        yield return new WaitForSeconds(timeAttack);
        
        weaponCollider.SetActive(false);
    }
}
