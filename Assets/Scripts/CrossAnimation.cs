using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimation : MonoBehaviour {

	public GameObject upCur,downCur,leftCur,rightCur;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			upCur.GetComponent<Animator>().enabled = true;
			downCur.GetComponent<Animator>().enabled=true;
			leftCur.GetComponent<Animator>().enabled=true;
			rightCur.GetComponent<Animator>().enabled=true;
			StartCoroutine( WaitingAnim () );
		}
	}

	IEnumerator WaitingAnim(){
		float time = 0.1f;
		yield return new WaitForSeconds (time);
		upCur.GetComponent<Animator> ().enabled = false;
		downCur.GetComponent<Animator> ().enabled = false;
		leftCur.GetComponent<Animator> ().enabled = false;
		rightCur.GetComponent<Animator> ().enabled = false;
	}
}
