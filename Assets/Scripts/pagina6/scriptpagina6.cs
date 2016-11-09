using UnityEngine;
using System.Collections;

public class scriptpagina6 : MonoBehaviour {
	public static int puntos = 0;
	public GameObject interfaz;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if(puntos >= 4){
			StartCoroutine (carga_Interfaz());
			puntos = 0;
		}
	}

	public IEnumerator carga_Interfaz(){
		yield return new WaitForSeconds (1f);
		GameObject newinterfaz = Instantiate (interfaz);
	}

	public void presionar_Boton(){			
		Destroy (GameObject.Find ("Pagina_6UI(Clone)"));
	}
}
