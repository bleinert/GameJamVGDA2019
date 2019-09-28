using UnityEngine;

public class EnMovement : MonoBehaviour
{

    float constantSpeed = 200f;
    public Rigidbody2D rb;


    // Update is called once per frame
    void Start(){
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        rb.velocity = (constantSpeed) * (rb.velocity);
    }
}
