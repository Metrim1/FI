using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour {

	Collider hitBoxColl;
	public static int GreenResCount = 0;

	void Awake () {
		hitBoxColl = GetComponent<Collider> ();
	}

	void Update () {

	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Resource") {
			Destroy (other.gameObject);
			GreenResCount += 1;
			ResSpawn.resConuter -= 1;
			//Debug.Log ("hui");
		}
	}
}
