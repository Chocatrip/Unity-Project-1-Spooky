using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    private int health;
    public Text healthText;
    public PlayerStats healthUpdate;
   
    void Update()
    {
        healthUpdate = GameObject.Find("PlayerManager").GetComponent<PlayerStats>();
        health = healthUpdate.health;       
        healthText.text = "HP > " + health;

    }
}
