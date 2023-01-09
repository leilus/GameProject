using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHealth = 100f;
    public float health;
    private UnityEngine.Object enemyRef;

    void Start()
    {   //in folder "resources" we're finding object with this name
        enemyRef = Resources.Load("Enemy");
        health = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            Die();
        }

    void Die()
        {
            Destroy(gameObject);
        }
    }


   
}