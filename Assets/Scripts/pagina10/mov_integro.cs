using UnityEngine;
using System.Collections;

public class mov_integro : MonoBehaviour {

	bool ban;
	public static int otra;
	void Start(){
		ban = false;
		otra = 0;
	}

	void Update (){
		if (ban == false) {
			mover ();
		}
	}

	void mover(){
		transform.Translate (0f, -80f * Time.deltaTime, 0f);
	}

	void OnTriggerEnter(Collider obj){
		GameObject otro = GameObject.Find ("ser_integro");
		if (obj.gameObject.tag == "freno") {
			ban = true;
			otra = 1;
		}

	}

}
