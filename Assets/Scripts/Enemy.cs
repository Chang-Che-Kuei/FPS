using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int enemyHealth = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHealth <= 0) {
			gameObject.SetActive (false);
		}
	}

	void DeductPoints(int damageAmount){
		enemyHealth -= damageAmount;
	}
}
