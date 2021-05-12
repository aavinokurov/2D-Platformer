using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCoins : MonoBehaviour
{
    [SerializeField] private GameObject checkCoinsText;
    [SerializeField] private GameObject platform;
    [SerializeField] private int needCoins;
    [SerializeField] private GameObject cutsceneStart;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 11)
        {
            if (CoinController.countCoin < needCoins)
            {
                checkCoinsText.SetActive(true);
            }
            else
            {
                platform.SetActive(true);
                cutsceneStart.SetActive(true);
                CoinController.countCoin -= needCoins;
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == 11)
        {
            checkCoinsText.SetActive(false);
        }
    }
}
