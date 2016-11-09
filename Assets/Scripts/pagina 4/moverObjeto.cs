using UnityEngine;
using System.Collections;

public class moverObjeto : MonoBehaviour {
	bool control;
	public string nombre;
	public GameObject texto;
	public AudioClip tono;
	AudioSource sonido;
	// Use this for initialization
	void Start () {
		sonido = GetComponent<AudioSource> ();
		control = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!control){
			mover ();
		}
	}

	void mover(){
		transform.Translate (80 * Time.deltaTime, 0, 0);
	}

	void OnTriggerEnter(Collider obj){
		GameObject otro = GameObject.Find (nombre);
		if (obj.gameObject.name == "centro") {
			sonido.clip = tono;
			sonido.Play ();
		}
		if(obj.gameObject.name == "objectRef"){
			control = true;
			Destroy (this.gameObject);
			Destroy (texto);
		}
	}
}
