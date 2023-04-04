using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    private Vector2 screenBounds;
    public float speed;
    private Rigidbody2D potion;
    public float timer = 5;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        potion = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (potion.position.x > (-screenBounds.x* 1.2))
        {
        potion.velocity = new Vector2(-speed, 0);
        }
        else
        {
            potion.velocity = new Vector2(0, 0);
        }

        if(potion.velocity.x == 0)
        {
            timer = timer - 1 * Time.deltaTime;
            if(timer <= 0)
            {
                Destroy(this.gameObject);
            }
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
