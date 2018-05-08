using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResProp : MonoBehaviour {

	public static Rigidbody resRB;
	public static Transform resT;
	public static Vector3 resV3;
	public static Collider resColl;

	// Use this for initialization
	void Start () {
		resRB = GetComponent<Rigidbody> ();
		resT = GetComponent<Transform> ();
		resV3 = transform.position;
		resColl = GetComponent<Collider> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
