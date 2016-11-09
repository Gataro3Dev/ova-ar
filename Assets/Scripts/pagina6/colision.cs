using UnityEngine;
using System.Collections;

public class colision : MonoBehaviour {
	public string objetoCol;
	public string golpe;
	int control;
	// Use this for initialization
	void Start () {
		control = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider colision) {
		GameObject objeto = GameObject.Find (objetoCol);
		if(colision.gameObject.name == golpe){ 
			if(control == 0){
				scriptpagina6.puntos+=1;
				control = 1;
				Debug.Log (scriptPagina3.puntaje);
			}

		}
	}
}
