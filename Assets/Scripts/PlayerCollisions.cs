using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private PlayerStats playerManager;
    void Start()
    {
        playerManager = GameObject.Find("PlayerManager").GetComponent<PlayerStats>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Book")
        {
            playerManager.loseHealth();
        }
        if(collision.tag == "Potion")
        {
            playerManager.gainLife();
        }
        if(collision.tag == "Coin")
        {
            playerManager.gainCoin();
        }
    }
    
}
