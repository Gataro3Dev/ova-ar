﻿using UnityEngine;
using System.Collections;

public class mov_engra_inver : MonoBehaviour {

	void Update (){
		mover ();
	}

	void mover(){
		transform.Rotate (0f, 0f, -80f * Time.deltaTime);
	}
}