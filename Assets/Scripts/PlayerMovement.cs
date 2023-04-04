using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D player;
    public float moveSpeedUp = 5000f;
    public float moveSpeedSides = 5000f;
    public float dashSpeed;
    public float dashTime;
    public float dashCooldown;
    private Vector2 screenBounds;
    private Joystick joystick;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        joystick = GameObject.Find("Variable Joystick").GetComponent<VariableJoystick>();
    }

    void Update()
    {
        if (dashCooldown <= 0)
        {
            if (Input.GetKeyDown("z"))
            {
                dashTime = 0.5f;
                dashCooldown = 4f;
            }
        }
    }
    void FixedUpdate()
    {
        float axisX = (joystick.Horizontal * moveSpeedSides) * Time.deltaTime;
        float axisY = (joystick.Vertical * moveSpeedUp) * Time.deltaTime;
                    
        if (dashTime >= 0)
        {
            axisX = (joystick.Horizontal * dashSpeed) * Time.deltaTime;
            axisY = (joystick.Vertical * dashSpeed) * Time.deltaTime;
            player.velocity = new Vector2(axisX, axisY);
            dashTime = dashTime - 1 * Time.deltaTime;
        }
        else
        {
            player.velocity = new Vector2(axisX, axisY);
        }
        dashCooldown = dashCooldown - 1 * Time.deltaTime;

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (transform.position.x<screenBounds.x)
        {
            this.gameObject.SetActive(false);
        } 
    }



}
