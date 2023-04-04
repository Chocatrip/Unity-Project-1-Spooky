using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public GameObject Player;
    public int maxHealth = 5;
    public int health;
    public int coins;
    private Vector2 screenBounds;


    void Start()
    {
        health = maxHealth;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }
    void Update()
    {
        if(health <= 0)
        {
            Player.SetActive(false);
        }
    }

    public void setPlayerActive()
    {
        Player.SetActive(true);
        health = maxHealth;
        Player.transform.position = new Vector3(screenBounds.x/7,screenBounds.y/7, 0);
    }
    public void gainLife()
    {
        health += 2;
        if( health >= maxHealth)
        {
            health = maxHealth;
        }
    }
    public void loseHealth()
    {
        health--;

    }
    public void gainCoin()
    {
        coins++;
    }

}
