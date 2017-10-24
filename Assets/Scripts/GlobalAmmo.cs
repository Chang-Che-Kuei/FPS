using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour {
	
	public static int currentAmmo;
	public GameObject ammoDisplay;

	private int internalAmmo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		internalAmmo = currentAmmo;
		ammoDisplay.GetComponent<Text>().text = "Ammo " + internalAmmo;
	}
}
