using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

	public AudioSource ammoSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col){
		ammoSound.Play ();
		GlobalAmmo.currentAmmo += 10;
		gameObject.SetActive (false);
	}
}
