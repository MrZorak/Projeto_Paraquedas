using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovimento : MonoBehaviour {
	public static Vector3 PosicaoObjetoVazio;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PosicaoObjetoVazio = transform.position;
		transform.Translate (new Vector3 (0f, 0f, 0.1f));
		
	}
}
