using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    private Rigidbody2D Background;
    public float speed;

    void Start()
    {
        Background = this.gameObject.GetComponent<Rigidbody2D>();
        Background.velocity = new Vector2(-speed, 0);
    }

}
