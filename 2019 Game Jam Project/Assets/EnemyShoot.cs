using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    GameObject Target;
    Vector3 direction;
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    Vector3 offset = new Vector3(1f, -0.1f, 0f);
    float delay = 0f;
    [SerializeField]
    float delayMax = .3f;
    // Start is called before the first frame update
    void Start()
    {
        delay = 0f; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            direction = Target.transform.position - transform.position + offset;
        
            if (delay > delayMax)
            {
                Instantiate(bullet, direction, transform.rotation);
            delay = 0;
            }

        delay += Time.fixedDeltaTime;
    }
}
