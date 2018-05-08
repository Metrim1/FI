using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBorder : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player")
			other.transform.position = new Vector3 (0f, 0.5f, 0f);
		if (other.gameObject.tag == "BM")
			Destroy (other.gameObject);
			
	}
	void Start () {
		
	}
	

	void Update () {
		
	}
}
