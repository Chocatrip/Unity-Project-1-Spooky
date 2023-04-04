using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScriptUI : MonoBehaviour
{
    private int coins;
    public Text coinText;
    public PlayerStats coinUpdate;
  
    void Update()
    {
        
     coinUpdate = GameObject.Find("PlayerManager").GetComponent<PlayerStats>();
     coins = coinUpdate.coins;
     coinText.text = "Coins> " + coins;
    }
}
