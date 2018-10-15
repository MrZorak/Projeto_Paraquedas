using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoTransDins : MonoBehaviour {

	private ObjetoTransparente paredeTranScript;
	private Renderer renderMaterial = new Renderer ();

	// Use this for initialization
	void Start () {
		GameObject transp = GameObject.Find ("Main Camera");
		paredeTranScript = transp.GetComponent<ObjetoTransparente> ();

		renderMaterial = gameObject.GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () {
		for (int m = 0; m < renderMaterial.materials.Length; m++) {
			if (paredeTranScript.hitpoint.transform == transform) {
				if (renderMaterial.materials [m].color.a > 0.3f) {
					Color cor = renderMaterial.materials [m].color;
					cor.a -= 0.06f;
					renderMaterial.materials [m].color = cor;
				}
			} else if (renderMaterial.materials [m].color.a < 1) {
				Color cor = renderMaterial.materials [m].color;
				cor.a += 0.06f;
				renderMaterial.materials [m].color = cor;
			}
		}
	}
}
