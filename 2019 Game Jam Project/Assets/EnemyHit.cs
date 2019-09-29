using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{

    SpriteRenderer render;
    Color color;
    HealthController health;
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        health = GetComponent<HealthController>();
        health.OnHit += HandleHit;
        color = render.color;
    }
    void HandleHit()
    {
        StartCoroutine(Flashing());
        Debug.Log("Hit");
    }
    private IEnumerator Flashing()
    {
        render.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        render.color = color;
    }
}
