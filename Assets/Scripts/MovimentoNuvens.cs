﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoNuvens : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0.1f, 0.04f, 0f));
	}
}
