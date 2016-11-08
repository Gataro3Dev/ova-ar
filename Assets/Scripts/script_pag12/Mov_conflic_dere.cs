using UnityEngine;
using System.Collections;

public class Mov_conflic_dere : MonoBehaviour {
	bool ban;
	public Rigidbody z;

	public static int num;

	void Start(){
		ban = false;
		z = GetComponent<Rigidbody> ();
		num = 0;
	}

	void Update (){
		if (ban == false) {
			mover ();
		}
	}

	void mover(){
		transform.Translate (80f * Time.deltaTime, 0f, 0f);
	}

	void OnTriggerEnter(Collider obj){
		GameObject otro = GameObject.Find("conflicto");
		if (obj.gameObject.tag == "freno") {
			ban = true;
			num = 1;
		}

	}
}
