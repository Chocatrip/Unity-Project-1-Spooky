using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float coinSpeed;
    private Rigidbody2D coin;
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        coin = this.gameObject.GetComponent<Rigidbody2D>();
        coin.velocity = new Vector2(-coinSpeed, 0);
    }

    void Update()
    {
        if (transform.position.x < screenBounds.x * 2)
        {
            Destroy(this.gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            Destroy(this.gameObject);
        }
    }

}
