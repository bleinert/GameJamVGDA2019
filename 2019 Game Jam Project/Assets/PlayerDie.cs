using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDie : MonoBehaviour
{
    [SerializeField]
    Canvas dieText;
    HealthController health;
    SpriteRenderer render;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<HealthController>();
        health.OnDie += HandleDie;
        render = GetComponent<SpriteRenderer>();
        dieText.enabled = false;
    }

    void HandleDie()
    {
        dieText.enabled = true;
        StartCoroutine(LoadDelay());
    }

    IEnumerator LoadDelay()
    {
        render.enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(2f);
        Debug.Log("Loading Level");
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
        render.enabled = true;
        dieText.enabled = false;
    }
}
