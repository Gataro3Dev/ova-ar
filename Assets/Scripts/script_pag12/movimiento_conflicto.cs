using UnityEngine;
using System.Collections;

public class movimiento_conflicto : MonoBehaviour {

	bool ban;


	void Start(){
		ban = false;
	}

	void Update (){
		if (ban == false) {
			mover ();
		}
	}

	void mover(){
		transform.Translate (0f, -25f * Time.deltaTime, 0f);
	}

	void OnTriggerEnter(Collider obj){
		GameObject otro = GameObject.Find ("conflicto");
		if (obj.gameObject.tag == "freno") {
			ban = true;
		}
			
	}


}
