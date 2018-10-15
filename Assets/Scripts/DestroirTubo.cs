using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroirTubo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (Destroir ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Destroir(){
		yield return new WaitForSeconds (10f);
		Destroy (gameObject);
	
	}
}
