using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDie : MonoBehaviour
{
    HealthController health;
    SpriteRenderer render;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<HealthController>();
        health.OnDie += HandleDie;
        render = GetComponent<SpriteRenderer>();
    }

    void HandleDie()
    {
        StartCoroutine(LoadDelay());
    }

    IEnumerator LoadDelay()
    {
        render.enabled = false;
        yield return new WaitForSeconds(2f);
        Debug.Log("Loading Level");
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        render.enabled = true;

    }
}
