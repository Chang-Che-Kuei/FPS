using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour {

	public int damageAmount = 5;
	public float targetDistance;
	public float allowedRange = 15f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			RaycastHit shot;
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out shot)) {
				targetDistance = shot.distance;
				if (targetDistance < allowedRange) {
					shot.transform.SendMessage("DeductPoints", damageAmount);
				}
			}
		}
	}
}
