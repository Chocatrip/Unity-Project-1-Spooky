using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 10f;
    public float speedMultiplier;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public DeployObstacles speedChanger;
    void Start()
    {
        speedChanger = GameObject.FindGameObjectWithTag("Spawner").GetComponent<DeployObstacles>();
        speedMultiplier = speedChanger.speedMultiplier;
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed*speedMultiplier, 0);

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void FixedUpdate()
    {
     if(transform.position.x < screenBounds.x*2)
        {
            Destroy(this.gameObject);
        }  
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(this.gameObject);
        }
  
    }
}

