using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimento : MonoBehaviour {

	public Vector2 startPos;
	public Vector2 direction;
    float currentOffset = -17.20f;
	public GameObject StraightRoad;
	Vector3 posicao;
	SkinnedMeshRenderer Skin;

	// Use this for initialization
	void Start () {
		Skin = GameObject.Find ("soldado").GetComponentInChildren<SkinnedMeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (new Vector3 (0f,0f,0.1f));

		if (Input.touchCount > 0) {
			Touch touch = Input.GetTouch (0);
			switch (touch.phase)
			{
			//When a touch has first been detected, change the message and record the starting position
			case TouchPhase.Began:
				// Record initial touch position.
				startPos = touch.position;
				break;

				//Determine if the touch is a moving touch
			case TouchPhase.Moved:
				// Determine direction by comparing the current touch position with the initial one
				direction = touch.position - startPos;
				if (direction.x < -50) {
					print (direction.x);
					transform.position = new Vector3 (-1f, 7.34f, 0f);				
				}
				if (direction.x > 50) {
					print (direction.x);
					transform.position = new Vector3 (1f, 7.34f, 0f);
				}
				break;
			}
			
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
		
			posicao = gameObject.transform.position;
			transform.position = new Vector3 (0.7f, posicao.y);
			
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {

			posicao = gameObject.transform.position;
			transform.position = new Vector3 (-0.7f, posicao.y);
		
		}


	}

	void OnTriggerEnter(Collider other)
	{
	
		if (other.tag == "Respawn") {
			Vector3 localOffset = new Vector3(0,currentOffset,0); //offset for first road block
			Vector3 spawnPosition = StraightRoad.transform.position + localOffset;
			StraightRoad.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
			Instantiate(StraightRoad, spawnPosition, StraightRoad.transform.rotation); //instantiate first new block, this works fine
			currentOffset -= 17.28f;
					
		}
		if (other.tag == "Obstaculo") {
			CameraShake.shakeDuration = 10f;
			StartCoroutine (LevouDano ());
			StartCoroutine (Shake ());

		}
	
	}

	IEnumerator Shake(){
		yield return new WaitForSeconds (0.2f);
		CameraShake.shakeDuration = 0f;
		print ("volta camera caralho" + CameraShake.shakeDuration);
	
	}

	IEnumerator LevouDano(){
		yield return new WaitForSeconds (0.1f);
		Skin.enabled = !Skin.enabled;
		yield return new WaitForSeconds (0.2f);
		Skin.enabled = !Skin.enabled;
		yield return new WaitForSeconds (0.2f);
		Skin.enabled = !Skin.enabled;
		yield return new WaitForSeconds (0.2f);
		Skin.enabled = !Skin.enabled;
		yield return new WaitForSeconds (0.2f);
		Skin.enabled = !Skin.enabled;
		yield return new WaitForSeconds (0.2f);
		Skin.enabled = !Skin.enabled;

	
	}
}
