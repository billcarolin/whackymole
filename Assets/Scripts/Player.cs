﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int score = 0;
	public Hammer hammer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (GvrViewer.Instance.Triggered || Input.GetKeyDown("space")) {
	//	if (Input.GetKeyDown("space")) {
	//		RaycastHit hit;
		//
		//	if (Physics.Raycast(transform.position, transform.forward, out hit)) {
		//		if (hit.transform.GetComponent<Mole> () != null) {
		//			Mole mole = hit.transform.GetComponent<Mole> ();
		//			mole.OnHit ();
		//			hammer.Hit (mole.transform.position);
		//
		//			score++;
		//		}
		//	}
		//}
	}
}
