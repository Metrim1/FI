using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBorders : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Resource"){
			Rigidbody otherRB = other.GetComponent<Rigidbody> ();
			otherRB.AddForce ((GameObject.FindGameObjectWithTag ("Player").transform.position - otherRB.transform.position) * 1);
	
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
