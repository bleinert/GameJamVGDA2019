using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float bulletLifeTime = 3f;
    float time = 0f;
    [SerializeField]
    float bulletSpeed = 100f;
    [SerializeField]
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

     void OnEnable()
    {
        time = 0f; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
   //    if(bulletLifeTime > time)
       // {
      //      time = 0;
      //      gameObject.SetActive(false);
      //  }
       time += Time.fixedDeltaTime;
       rb.velocity = new Vector2(bulletSpeed, 0);
    }
}
