using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadMenu : MonoBehaviour
{
    public GameObject deadMenuUI;
    public PlayerStats playerManager;
    void Start()
    {
        playerManager = GameObject.Find("PlayerManager").GetComponent<PlayerStats>();
    }

    void Update()
    {
            if (GameObject.FindWithTag("Player")!=null)
            {
                deadMenuUI.SetActive(false);
                Time.timeScale = 1f;
             }else{
                deadMenuUI.SetActive(true);
                Time.timeScale = 0f;
            }
        
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }

    public void Continue()
    {
        playerManager.setPlayerActive();
        Time.timeScale = 1f;
        deadMenuUI.SetActive(false);
    }
}
