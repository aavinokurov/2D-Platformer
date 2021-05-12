using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    [SerializeField] private Text countCoinText;

    public static int countCoin;

    private void Start()
    {
        countCoin = 0;
    }

    private void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.gameObject.layer == 14)
        {
            countCoin++;
            countCoinText.text = countCoin.ToString();
            Destroy(coin.gameObject);
        }
    }
}
