using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour {

	public int playerHealth = 100;
	public int playerCurrentHealth= playerHealth;
	public Slider healthBar;
	public Image fillImage;
	public Color fullHealth = Color.red;
	public Color zeroHealth = Color.black;

	// Use this for initialization
	public void PlayerTakeDamage(int damage)
	{
		playerCurrentHealth -= damage;
		SetHealthUI ();
		print ("player hurt " + playerHealth);
		if (playerHealth <= 0)
		{
			Destroy(gameObject);
		}
	}
	public void SetHealthUI()
	{
		healthBar.value = playerCurrentHealth;
		fillImage.color = Color.Lerp (zeroHealth, fullHealth, playerCurrentHealth / playerHealth);
	}
		
}
