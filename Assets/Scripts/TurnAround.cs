﻿using UnityEngine;
using System.Collections;

public class TurnAround : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(this.transform.position, this.transform.up, 1.0f);
	}
}
