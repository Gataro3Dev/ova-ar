using UnityEngine;
using System.Collections;
using System;

public class ScriptPagina3NO : MonoBehaviour {

	public GameObject [] imagenes;
	public GameObject[] hitoPos;
	private bool estadoJuego;
	private Ray pulso;
	private RaycastHit colision;
	private Vector3 targetpos1;
	private Vector3 targetpos2;
	public static string moverObjeto;
	int primero;
	float velocidad = 100f;
	public bool controlMov{ get; set; }
	int generador1;
	int generador2;
	// Use this for initialization
	void Start () {
		primero = 0;
		estadoJuego = true;
		controlMov = false;
		moverObjeto = "noActivo";
	}
	
	// Update is called once per frame
	void Update () {
		if(estadoJuego){
			if (Input.GetMouseButtonDown (0)) {
				pulso = Camera.main.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (pulso, out colision)) {
					if (colision.collider.name == "parte1") {
						if (primero == 0) {
							Debug.Log (primero);
							targetpos1 = hitoPos [0].transform.position;
							primero = 1;
							generador1 = 1;
							Debug.Log (generador1);
						} else {	
							Debug.Log (primero);
							targetpos2 = hitoPos [0].transform.position;
							primero = 0;
							generador2 = 11;
							Debug.Log (generador2);
							controlMov = true;
						}
					}
					if(colision.collider.name == "parte2"){
						if (primero == 0) {
							Debug.Log (primero);
							targetpos1 = hitoPos [1].transform.position;
							primero = 1;
							generador1 = 2;
							Debug.Log (generador1);
						} else {
							Debug.Log (primero);
							targetpos2 = hitoPos [1].transform.position;
							primero = 0;
							generador2 = 21;
							Debug.Log (generador2);
							controlMov = true;
						}
					}
					if(colision.collider.name == "parte3"){
						if (primero == 0) {
							Debug.Log (primero);
							targetpos1 = hitoPos [2].transform.position;
							primero = 1;
							generador1 = 3;
							Debug.Log (generador1);
						} else {
							Debug.Log (primero);
							targetpos2 = hitoPos [2].transform.position;
							primero = 0;
							generador2 = 31;
							Debug.Log (generador2);
							controlMov = true;
						}
					}
					if(colision.collider.name == "parte4"){
						if (primero == 0) {
							Debug.Log (primero);
							targetpos1 = hitoPos [3].transform.position;
							primero = 1;
							generador1 = 4;
							Debug.Log (generador1);
						} else {
							Debug.Log (primero);
							targetpos2 = hitoPos [3].transform.position;
							primero = 0;
							generador2 = 41;
							Debug.Log (generador2);
							controlMov = true;
						}
					}
				}
			}
		}
		if(controlMov){
			try{
				if(generador1 == 1 && generador2 == 21){
					if(mover(targetpos1, targetpos2, imagenes[0], imagenes[1])){
						controlMov = false;
					}
				}
				if(generador1 == 1 && generador2 == 31){
					if(mover(targetpos1, targetpos2, imagenes[0], imagenes[2])){
						controlMov = false;
					}
				}
				if(generador1 == 1 && generador2 == 41){
					if(mover(targetpos1, targetpos2, imagenes[0], imagenes[3])){
						controlMov = false;
					}
				}
				if(generador1 == 2 && generador2 == 11){
					if(mover(targetpos1, targetpos2, imagenes[1], imagenes[0])){
						controlMov = false;
					}
				}
				if(generador1 == 2 && generador2 == 31){
					if(mover(targetpos1, targetpos2, imagenes[1], imagenes[2])){
						controlMov = true;
					}
				}
				if(generador1 == 2 && generador2 == 41){
					if(mover(targetpos1, targetpos2, imagenes[1], imagenes[3])){
						controlMov = false;
					}
				}
				if(generador1 == 3 && generador2 == 11){
					if(mover(targetpos1, targetpos2, imagenes[2], imagenes[0])){
						controlMov = false;
					}
				}
				if(generador1 == 3 && generador2 == 21){
					if(mover(targetpos1, targetpos2, imagenes[2], imagenes[1])){
						controlMov = false;
					}
				}
				if(generador1 == 3 && generador2 == 4.1){
					if(mover(targetpos1, targetpos2, imagenes[2], imagenes[3])){
						controlMov = false;
					}
				}
				if(generador1 == 4 && generador2 == 11){
					if(mover(targetpos1, targetpos2, imagenes[3], imagenes[0])){
						controlMov = false;
					}
				}
				if(generador1 == 4 && generador2 == 21){
					if(mover(targetpos1, targetpos2, imagenes[3], imagenes[1])){
						controlMov = false;
					}
				}
				if(generador1 == 4 && generador2 == 31){
					if(mover(targetpos1, targetpos2, imagenes[3], imagenes[2])){
						controlMov = false;
					}
				}
			}catch{
			}
		}
	}

	private bool mover(Vector3 objeto1, Vector3 objeto2, GameObject uno, GameObject dos){
		Vector3 objetivo1 = objeto2 - uno.transform.position;
		Vector3 objetivo2 = objeto1 - dos.transform.position;
		objetivo1 = new Vector3 (objetivo1.x, 0, objetivo1.z);
		objetivo2 = new Vector3 (objetivo2.x, 0, objetivo2.z);

		if ((Math.Abs (objetivo1.x) > 0.2f || Math.Abs (objetivo1.y) > 0.2f || Math.Abs (objetivo1.z) > 0.2f)  &&  (Math.Abs (objetivo2.x) > 0.2f || Math.Abs (objetivo2.y) > 0.2f || Math.Abs (objetivo2.z) > 0.2f)) {
			objetivo1.Normalize ();
			objetivo2.Normalize ();
			objetivo1 *= velocidad;
			objetivo2 *= velocidad;
			objetivo1 = new Vector3 (objetivo1.x, objetivo1.y, objetivo1.z);
			objetivo2 = new Vector3 (objetivo2.x, objetivo2.y, objetivo2.z);
			uno.transform.Translate (objetivo1 * Time.deltaTime, Space.World);
			dos.transform.Translate (objetivo2 * Time.deltaTime, Space.World);
			return false;
		} else {
			return true;
		}
	}
}
