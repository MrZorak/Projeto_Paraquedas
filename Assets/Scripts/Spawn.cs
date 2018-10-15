using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject []Obstaculo;
	int randonnumber;
	int randonposition;
	static public float velocidade = 0.02f;
	float velocidadespawn = 7f;
	Vector3 posicao;

	// Use this for initialization
	void Start () {
		StartCoroutine (SpawnObjetos ());
		StartCoroutine (Dificuldade ());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnObjetos(){
		yield return new WaitForSeconds (velocidadespawn);
		randonnumber = Random.Range(0,5);
		randonposition = Random.Range (0, 6);
		print (randonposition);
		if (randonposition == 0 || randonposition == 2) {
			print ("esquerda");
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (-1f, posicao.y);
		}
		if (randonposition == 1 || randonposition == 3) {
			print ("direita");
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (1f, posicao.y);
		}
		if (randonnumber == 4 || randonnumber == 5) {
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (0f, posicao.y);
		}

		Instantiate (Obstaculo [randonnumber], transform.position, transform.rotation);
		StartCoroutine (SpawnObjetos ());
	
	}

	IEnumerator Dificuldade(){
		yield return new WaitForSeconds (20f);
		velocidadespawn = velocidadespawn + 0.5f;
		velocidade = velocidade + 0.01f;
		print (velocidade);
		StartCoroutine (Dificuldade ());

	}
}
