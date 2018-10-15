using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

	public Transform camTransform;


	public static float shakeDuration = 0f;


	float shakeAmount = 0.2f;
	float decreaseFactor = 1.0f;

	Vector3 originalPos;

	void Awake()
	{

		originalPos = camTransform.localPosition;
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}


	void Update()
	{
		

		if (shakeDuration > 0)
		{
			camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

			shakeDuration -= decreaseFactor;
		}
			
	}

}
