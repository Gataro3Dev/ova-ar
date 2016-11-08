using UnityEngine;
using System.Collections;

public class scriptPagina3 : MonoBehaviour {
	public static int puntaje = 0;
	public GameObject interfaz;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(puntaje >= 4){
			StartCoroutine (carga_Interfaz());
			puntaje = 0;
		}
	}

	public IEnumerator carga_Interfaz(){
		yield return new WaitForSeconds (1f);
		GameObject newInterfaz = Instantiate (interfaz);
	}

	public void presionar_Boton(){			
		Destroy (GameObject.Find ("Pagina_3UI(Clone)"));
	}
}
