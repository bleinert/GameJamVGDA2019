using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    Vector3 offset = new Vector3(1f, -0.1f, 0f);
    float delay = 0f;
    [SerializeField]
    float delayMax = .3f;
    Vector3 velocity;
    [SerializeField]
    AudioSource sound;
    public PlayerStatsSO player;
    HealthController health;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<HealthController>();
        delay = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity = transform.position+offset;
        velocity += transform.forward.normalized * 8f;
        if (Input.GetMouseButton(0))
        {
            if (delay > delayMax && health.CurrentHealth >= 1)
            {
                Instantiate(bullet, velocity, transform.rotation);
                delay = 0;
                sound.Play();
                player.playerFuel -= 2f;
                
            }

        }
        delay += Time.fixedDeltaTime;
    }
}
