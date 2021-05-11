using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinController : MonoBehaviour
{
    [SerializeField] private Text countCoinText;

    private static int countCoin;

    private void Start()
    {
        countCoin = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 11)
        {
            countCoin++;
            countCoinText.text = countCoin.ToString();
            Destroy(gameObject);
        }
    }
}
