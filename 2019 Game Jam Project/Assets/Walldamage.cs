using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Walldamage : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject player;

  
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag.Equals("Wall"))
        {

            player.GetComponent<IHealth>().RecieveDamage(1);

        }
        else if(col.gameObject.tag.Equals("End Wall"))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }
}
