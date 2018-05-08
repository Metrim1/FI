using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


	//PlayerController playerController; 
	public Transform player;

	Vector3 camRange;
	//Vector3 playerPos;
	//Vector3 camPos;
	//Vector3 targetCamPos;

	//Vector3 offset;

	//public float speedH = 2f;
	//float rotationCam;
	//float rotationPlayer;
	//private Quaternion startrotation;
	void Awake(){

	}


	// Use this for initialization
	void Start () {
		//startrotation = transform.rotation;

		camRange = transform.position - player.position;
	}


	void FixedUpdate(){
		
		transform.position = player.position + camRange;
		//transform.position = targetCamPos;
		//transform.position = camRange;
	}

	/*void TurningAround(){
		
		rotationCam = rotationCam + Input.GetAxis ("Mouse X") * speedH;
		transform.RotateAround ( player.transform.position, Vector3.up, speedH * rotationCam * Time.deltaTime);
		//transform.position = camRange;
		//transform.RotateAround ( player.position, Vector3.up, speedH * rotationCam * Time.deltaTime);

	}*/

	void Update () {
		/*if (Input.GetMouseButton (2)){
			TurningAround();

		}
		if (Input.GetMouseButtonUp (2)){
			rotationCam = 0;
		}*/

		//transform.rotation = startrotation;
		//transform.LookAt (player);
	}
}
