using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepletingFuel : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerStatsSO playerstats;
   
    // Update is called once per frame
    void Update()
    {
        playerstats.playerFuel -= 1 * Time.deltaTime;
    }
}
