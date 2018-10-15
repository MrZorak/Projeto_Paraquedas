using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoGirando : MonoBehaviour {

	int mudarlado;
	int mudou;

	// Use this for initialization
	void Start () {
		StartCoroutine (Destroir ());
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (0f,Spawn.velocidade,0f * Time.deltaTime));
		transform.Rotate (new Vector3(0f,1.2f,0f * Time.deltaTime));
	}

	IEnumerator Destroir(){
		yield return new WaitForSeconds (10f);
		Destroy (gameObject);
	}


	 

}
