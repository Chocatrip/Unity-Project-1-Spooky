﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InamovibleObstacleMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
       

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x < screenBounds.x * 2)
        {
            Destroy(this.gameObject);
        }
        rb.velocity = new Vector2(-speed, 0);
    }
}

