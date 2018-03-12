using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

	public int playerHealth = 10;

	// Use this for initialization
	public void PlayerTakeDamage(int damage)
	{
		playerHealth -= damage;
		print ("player hurt " + playerHealth);
		if (playerHealth <= 0)
		{
			Destroy(gameObject);
		}
	}
}
