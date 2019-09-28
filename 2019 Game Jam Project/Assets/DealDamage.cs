﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<IHealth>();
        if(player != null)
        {
            player.RecieveDamage(10f);
        }
    }
}
