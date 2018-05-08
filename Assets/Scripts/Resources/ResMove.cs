using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResMove : MonoBehaviour {


	float moveForceX;
	float moveForceY;
	float moveForceZ;
	float rotatForceX;
	float rotatForceY;
	float rotatForceZ;
	public float moveF = 5f;
	public float moveT = 1f;


	Rigidbody resRB;

	void Awake () {
		resRB = GetComponent<Rigidbody> ();
		InvokeRepeating ("addMoveTorque", 0.1f, Random.Range (1f, 5f));
	}


	void addMoveTorque(){
	
		resRB.AddForce (moveForceX, moveForceY, moveForceZ);
		resRB.AddTorque (rotatForceX, rotatForceY, rotatForceZ);
	
	}
		
	void FixedUpdate () {
		
	}

	void Update (){
		

		moveForceX = Random.Range(moveF, -moveF);
		moveForceY = Random.Range(moveF, -moveF);
		moveForceZ = Random.Range(moveF, -moveF);
		rotatForceX = Random.Range(moveT, -moveT);
		rotatForceY = Random.Range(moveT, -moveT);
		rotatForceZ = Random.Range(moveT, -moveT);
	}
}
