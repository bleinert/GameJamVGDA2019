using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    Bullet bullet;
    [SerializeField]
    Vector3 offset = new Vector3(1f, -0.1f, 0f);
    float delay = 0f;
    [SerializeField]
    float delayMax = .3f;
    // Start is called before the first frame update
    void Start()
    {
        delay = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (delay > delayMax)
            {
                Debug.Log("Shoot");
                Instantiate(bullet, transform.position+offset, transform.rotation);
                delay = 0;
            }

        }
        delay += Time.fixedDeltaTime;
    }
}
