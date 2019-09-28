using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{

    [SerializeField]
    PlayerStatsSO stats;
    float health = 1;
    public Health{
        get{ return health;}
        set{ health = Ke
    }

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RecieveDamage(float damage)
    {

        throw new System.NotImplementedException();
    }
}
