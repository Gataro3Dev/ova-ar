using UnityEngine;
using System.Collections;

public class Mov_conflic_dere : MonoBehaviour {
	bool ban;
	public Rigidbody z;

	void Start(){
		ban = false;
		z = GetComponent<Rigidbody> ();
	}

	void Update (){
		if (ban == false) {
			mover ();
		}
	}

	void mover(){
		transform.Translate (25f * Time.deltaTime, 0f, 0f);
	}

	void OnTriggerEnter(Collider obj){
		GameObject otro = GameObject.Find("conflicto");
		if (obj.gameObject.tag == "freno") {
			ban = true;
		}

	}
}
