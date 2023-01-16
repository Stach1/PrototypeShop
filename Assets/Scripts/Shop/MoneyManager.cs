using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public float coins;
    public TMP_Text coinUI;


    private void Start()
    {
       
    }

    public void AddCoins(float cash)
    {
        coins += cash;
        coinUI.text = coins.ToString();
    }

    public void RemoveCoins(float cash)
    {
        coins -= cash;
        coinUI.text = coins.ToString();
    }
}
