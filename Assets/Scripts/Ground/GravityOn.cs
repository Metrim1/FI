using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOn : MonoBehaviour {

	GameObject[] floor;
	Vector3[] floorT;
	Rigidbody RB;
	public static int i;

	void Awake () {
		RB = GetComponent<Rigidbody> ();


		}


	void Update () {
		
		floor = GameObject.FindGameObjectsWithTag ("Floor");
		Vector3[] floorT = new Vector3[floor.Length];
		for (int i = 0; i < floor.Length; i++) {

			//Debug.Log (floor [i].name);
			floorT [i] = floor [i].GetComponent<Transform> ().transform.position;
			if (((int)transform.position.x == (int)floorT [i].x) && ((int)transform.position.z == (int)floorT [i].z)) {
				RB.useGravity = true;
			}
		}


		}

	void FixedUpdate(){
		
	
	}
}
