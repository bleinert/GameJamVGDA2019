using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    Vector3 offset = new Vector3(1f, -0.1f, 0f);
    float delay = 0f;
    [SerializeField]
    float delayMax = .3f;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        delay = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity = transform.position+offset;
        velocity += transform.forward.normalized * 8f;
        if (Input.GetMouseButton(0))
        {
            if (delay > delayMax)
            {
                Instantiate(bullet, velocity, transform.rotation);
                delay = 0;
            }

        }
        delay += Time.fixedDeltaTime;
    }
}
