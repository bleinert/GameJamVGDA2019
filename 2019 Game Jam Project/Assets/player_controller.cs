using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 15f;
    float characteraccel = 15f;
    public Rigidbody2D rb;
    Vector2 movement;
    [SerializeField]
    float flySpeed = 1f;
    Vector2 flyVector;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    //    movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical")*speed;
     
    }

    private void FixedUpdate()
    {
        flyVector = Vector3.right*speed;
       // movement += flyVector;
        rb.velocity = movement+flyVector * characteraccel * Time.fixedDeltaTime;
     //   rb.MovePosition(rb.position + movement * characteraccel * Time.fixedDeltaTime);
    }
}
