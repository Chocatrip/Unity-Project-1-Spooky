using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSpawner : MonoBehaviour
{
    public GameObject potionPrefab;
    public float minRespawnTime = 15f;
    public float maxRespawnTime = 20f;
    private float respawnTime;
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(obstacleWave());
        respawnTime = maxRespawnTime - minRespawnTime;
    }

    private void respawnTimeChanger()
    {
        respawnTime = Random.Range(minRespawnTime, maxRespawnTime);
    }
    private void spawnPotion()
    {
        GameObject a = Instantiate(potionPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -6, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator obstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPotion();
            respawnTimeChanger();
        }

    }
}
