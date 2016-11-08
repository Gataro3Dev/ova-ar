using UnityEngine;
using System.Collections;

public class nocruzar : MonoBehaviour {

	void OnCollisionEnter(Collision obj){
		GameObject otro = GameObject.Find ("fuego");
		if(obj.gameObject.tag=="fuego"){
			Destroy (otro);
		}
	}
}
