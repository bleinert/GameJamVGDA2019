﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 10f;
    float characteraccel = 1.0f;
    public Rigidbody2D rb;
    Vector2 movement;
    [SerializeField]
    float flySpeed = 1f;
    Vector2 flyVector;
    HealthController health;
    void Start()
    {
        health = GetComponent<HealthController>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //    movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical") * speed;
        flyVector = new Vector2(1 * flySpeed * Time.fixedDeltaTime, 0);
    }

    private void FixedUpdate()
    {
        if (health.CurrentHealth >= 1)
        {


            movement += flyVector;
            rb.MovePosition(rb.position + movement * characteraccel * Time.fixedDeltaTime);

        }

    }
}

