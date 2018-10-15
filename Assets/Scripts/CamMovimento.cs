using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovimento : MonoBehaviour {

	Vector3 posicaoOriginal;
	// Use this for initialization
	void Start () {
		StartCoroutine (InicioDoJogo ());
	}
	
	// Update is called once per frame
	void Update () {

		posicaoOriginal = transform.position;
		//transform.Translate (new Vector3 (0f,0f,0.1f));


	}

	IEnumerator InicioDoJogo(){
		yield return new WaitForSeconds (2f);
		PosicaoCamera ();
	}

	void PosicaoCamera(){
	
		if(CameraShake.shakeDuration == 0)
		{
			transform.position = (new Vector3 (0f, CameraMovimento.PosicaoObjetoVazio.y, 0f));
		}
	}
}
