using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 10;
    float characteraccel = 1.1f;
    public Rigidbody2D rb;
    Vector2 movement;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * characteraccel * Time.fixedDeltaTime);
    }
}
