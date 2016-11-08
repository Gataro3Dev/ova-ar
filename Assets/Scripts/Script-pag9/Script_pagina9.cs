using UnityEngine;
using System.Collections;

public class Script_pagina9 : MonoBehaviour {

	public GameObject otro;

	void Update () {
		if (nocruzar.numero == 1) {
			StartCoroutine (primero ());
			nocruzar.numero = 0;
		}
	}

	public IEnumerator primero(){
		yield return new WaitForSeconds(1f);
		GameObject nuevo = Instantiate (otro);
	}

	public void Presionar_boton(){
		Destroy (GameObject.Find ("Pagina_9UI(Clone)"));
	}
}
