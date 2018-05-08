using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	public float speed = 6f;
	public float jumpforce =5f;

	//private Transform m_Cam;                  // A reference to the main camera in the scenes transform
	//private Vector3 m_CamForward;             // The current forward direction of the camera

	Vector3 movement;
	Rigidbody camRigidbody;

	void Awake(){
		
		camRigidbody = GetComponent<Rigidbody> ();

	}


	void FixedUpdate () {
		float j = Input.GetAxis ("Jump");

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Move (h, v);
		Jumping (h, v, j);

	}

	void Move(float h, float v){

		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
		camRigidbody.MovePosition (transform.position + movement);

	}

	void Jumping(float h, float v, float j){

		movement.Set (h, j, v);
		movement = movement.normalized * speed * Time.deltaTime * jumpforce;
		camRigidbody.MovePosition (transform.position + movement);

	}


	void Update () {

	}
}
