﻿using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	public float tumble;

	// Use this for initialization
	void Start () {
		rigidbody.angularVelocity = Random.insideUnitCircle * tumble;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
