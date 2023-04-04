using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObstacles : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float minRespawnTime = 1.0f;
    public float maxRespawnTime = 4.0f;
    public float speedMultiplier=1f;
    private float respawnTime;
    private Vector2 screenBounds;
    private float tempMultiplier;

    private PlayerMovement playerPos;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(obstacleWave());
        StartCoroutine(obstacleForPlayer());
        respawnTime = maxRespawnTime - minRespawnTime;
        speedMultiplier = speedMultiplier + 1/35 * Time.deltaTime;
    }

    void Update()
    {
        try
        {
            if (GameObject.Find("Player").name == "Player")
            {
                tempMultiplier = (speedMultiplier * 1 / 200);
                speedMultiplier = speedMultiplier + tempMultiplier * Time.deltaTime;
            }
        }
        catch { }
            
            
       
       
        try
        {
            playerPos = GameObject.Find("Player").GetComponent<PlayerMovement>();
        }
        catch { }
           
        
    }
 
    private void respawnTimeChanger()
    {
        respawnTime = Random.Range(minRespawnTime, maxRespawnTime);
    }
    private void spawnEnemy()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -6, Random.Range(-screenBounds.y, screenBounds.y));
    }
    private void spawnEnemyToPlayer()
    {
        if(this.gameObject.name == "BookSpawner")
        {
            try
            {
                GameObject a = Instantiate(obstaclePrefab) as GameObject;
                a.transform.position = new Vector2(screenBounds.x*-6, playerPos.transform.position.y);
            }
            catch { }
            
        }
    }
    
    IEnumerator obstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
            respawnTimeChanger();
        }
        
    }
    IEnumerator obstacleForPlayer()
    {
        while (true)
        {
            yield return new WaitForSeconds(4);
            spawnEnemyToPlayer();
        }

    }
}
