using UnityEngine;
using System.Collections;

public class correcto : MonoBehaviour
{
	private static bool estadoJuego;

    void Start()
    {

}

    void Update()
    {

	
	}
	void OnMouseUpAsButton() {
		Destroy (gameObject);
		Destroy (GameObject.Find ("Pagina_5UI(Clone)"));
		estadoJuego = true;
	}
    
}