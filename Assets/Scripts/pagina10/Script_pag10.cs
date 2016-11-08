using UnityEngine;
using System.Collections;

public class Script_pag10 : MonoBehaviour {

	public GameObject otro;

	void Update () {
		if (mov_integro.otra == 1) {
			StartCoroutine (primero ());
			mov_integro.otra = 0;
		}
	}

	public IEnumerator primero(){
		yield return new WaitForSeconds(1f);
		GameObject nuevo = Instantiate (otro);
	}

	public void Presionar_boton(){
		Destroy (GameObject.Find ("Pagina_10UI(Clone)"));
	}
}
