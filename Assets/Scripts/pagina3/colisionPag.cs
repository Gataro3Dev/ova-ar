using UnityEngine;
using System.Collections;

public class colisionPag : MonoBehaviour {
	public string objetoCol;
	public string golpe; 
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider colision) {
		GameObject objeto = GameObject.Find (objetoCol);
		if(colision.gameObject.name == golpe){  
			scriptPagina3.puntaje += 1;
			Debug.Log (scriptPagina3.puntaje);
		}
    }

}
