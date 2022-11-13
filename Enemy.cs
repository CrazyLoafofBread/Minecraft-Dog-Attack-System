using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if(currentHealth < 0)
        {
            Death();
        }
    }

    void Death()
    {
        GameObject.Destroy(this.gameObject);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage * Time.deltaTime;
    }
}
