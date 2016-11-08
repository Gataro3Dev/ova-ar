using UnityEngine;
using System.Collections;

public class script_pag12 : MonoBehaviour {

	public GameObject otro;

	void Update () {
		if (Mov_conflic_dere.num == 1) {
			StartCoroutine (primero ());
			Mov_conflic_dere.num = 0;
		}
	}

	public IEnumerator primero(){
		yield return new WaitForSeconds(1f);
		GameObject nuevo = Instantiate (otro);
	}

	public void Presionar_boton(){
		Destroy (GameObject.Find ("Pagina_12UI(Clone)"));
	}

}
