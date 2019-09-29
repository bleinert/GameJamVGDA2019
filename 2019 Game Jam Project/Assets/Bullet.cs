using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float bulletLifeTime;
    // Start is called before the first frame update
    void Start()
    {
        bulletLifeTime = 0; 
    }

    void OnEnable()
    {
        bulletLifeTime = 0;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
