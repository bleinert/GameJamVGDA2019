using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Stats : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerStatsSO playerstats;
    public 
    void Start()
    {
        playerstats.playerFuel= 1;
        playerstats.playerHealth = 100;
        playerstats.playerSpeed = 1;



    }

}
