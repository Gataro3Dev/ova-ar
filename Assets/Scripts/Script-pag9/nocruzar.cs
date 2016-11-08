using UnityEngine;
using System.Collections;

public class nocruzar : MonoBehaviour {

	public static int numero=0;

	void OnCollisionEnter(Collision obj){
		GameObject otro = GameObject.Find ("fuego");
		if(obj.gameObject.tag=="fuego"){
			Destroy (otro);
			numero = 1;
		}
	}
}
