using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWallCcw : MonoBehaviour
{
    // Start is called before the first frame update
    float accelz = 90f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,accelz*Time.deltaTime);

    }
}
