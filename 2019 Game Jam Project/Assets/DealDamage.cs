using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<IHealth>();
        if(player != null)
        {
            player.RecieveDamage(1f);
        }
    }
}
