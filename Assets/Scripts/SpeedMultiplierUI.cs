using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedMultiplierUI : MonoBehaviour
{
    public Text speedMultiplierText;
    private float speedMultiplier;
    public DeployObstacles speedSource;

    
    void Update()
    {
        speedSource = GameObject.FindGameObjectWithTag("Spawner").GetComponent<DeployObstacles>();
        speedMultiplier = speedSource.speedMultiplier;
        speedMultiplierText.text = "Speed X " + speedMultiplier.ToString("f2");

    }
}
