using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNuvens : MonoBehaviour {
	Vector3 posicao;
	public GameObject []nuvens;
	int CalaBocaRoberto;
	float RandomPosz;

	// Use this for initialization
	void Start () {
		StartCoroutine (NuvensAleatorias ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator NuvensAleatorias(){
		yield return new WaitForSeconds (2f);
		CalaBocaRoberto = Random.Range (0, 7);
		RandomPosz = Random.Range (-7.36f, 7.59f);
		if (CalaBocaRoberto == 0) {
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (-17f, posicao.y, RandomPosz);
		}
		if (CalaBocaRoberto == 1) {
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (-17f, posicao.y, RandomPosz);
		}
		if (CalaBocaRoberto == 2) {
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (-17f, posicao.y, RandomPosz);
		}
		if (CalaBocaRoberto == 3) {
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (-17f, posicao.y, RandomPosz);
		}
		if (CalaBocaRoberto == 4) {
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (-17f, posicao.y, RandomPosz);
		}
		if (CalaBocaRoberto == 5) {
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (-17f, posicao.y, RandomPosz);
		}
		if (CalaBocaRoberto == 6) {
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (-17f, posicao.y, RandomPosz);
		}
		if (CalaBocaRoberto == 7) {
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (-17f, posicao.y, RandomPosz);
		}


		Instantiate (nuvens [CalaBocaRoberto], transform.position, transform.rotation);
		StartCoroutine (NuvensAleatorias ());
	
	}
}
