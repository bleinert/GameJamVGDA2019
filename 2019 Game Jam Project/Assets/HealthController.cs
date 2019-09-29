using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthController : MonoBehaviour, IHealth
{
    public event Action OnDie = delegate { };
    public event Action OnHit = delegate { };

    [SerializeField]
    private float health = 1;
    private bool isDead = false;
    public float CurrentHealth { get => health; set => health = value; }
    public bool IsDead { get => isDead; set => isDead = value; }

    public void RecieveDamage(float damage)
    {
       
        if (isDead)
        {
            return;
        }
        health--;
        OnHit();
        if(health <= 0)
        {
            Debug.Log("You Died");
            isDead = true;
            OnDie();
        }
    }
}
