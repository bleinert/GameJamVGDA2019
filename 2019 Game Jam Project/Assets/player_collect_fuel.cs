using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collect_fuel : MonoBehaviour
{
    // Start is called before the first frame update
   public  PlayerStatsSO player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            player.playerFuel += 20;
            Destroy(gameObject);

        }
    }
}
