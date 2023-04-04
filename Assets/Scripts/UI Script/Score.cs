using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private float score=0;
    private int scoreInt;
    public Text scoreText;
    void Update()
    {

        if (GameObject.FindWithTag("Player"))
        {
          score = score + 14 / 6 * Time.deltaTime;
          scoreInt = (int)score;
          scoreText.text = "Score: " + scoreInt;
        }
   
    }
}
