using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;//sets health to 100 at beggining

    public GameObject deathEffect;// creates a new game object

    public void TakeDamage(int damage) // call function from damage script, damage = 100
    {
        health -= damage;// damage is subtracted from health

        if (health <= 0)// if health = 0 or less than
        {
            Die();// call die function
        }
    }
    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);// die = destroy gameobject script is attached too
    }
}
