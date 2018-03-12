using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieBehaviour : MonoBehaviour
{

    public int health = 10;

    // Use this for initialization
    public void TakeDamage(int damage)
    {
		
        health -= damage;
		print (health);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

