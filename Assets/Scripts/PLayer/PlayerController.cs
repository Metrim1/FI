using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 6f;
	//public float turnSpeed = 2f;
	public Collider legs;
	public float jumpforce =5f;

	//private Transform m_Cam;                  // A reference to the main camera in the scenes transform
	//private Vector3 m_CamForward;             // The current forward direction of the camera

	//Vector3 movement;
	//Vector3 camV;
	Rigidbody playerRigidbody;
	//int floorMask;
	//public Rigidbody cam;
	//Transform camT;
	//Quaternion playerQ;
	//float camRayLength = 100f;
	//Vector3 cam;


	void Awake(){
		//floorMask = LayerMask.GetMask ("Floor");
		//cam = Camera.main.transform.position;
		//movement = transform.position;
		//camT = cam.transform;
		//camV = cam.transform.position;

		playerRigidbody = GetComponent<Rigidbody> ();

	}
	void Start () {
		//playerRigidbody.constraints = RigidbodyConstraints.FreezeRotationX & RigidbodyConstraints.FreezeRotationZ;
	}
	public bool canJump;
	void OnTiggerEnter(Collider legs){
		bool canJump = true;
		}

	void OnTiggerExit(Collider legs){
		bool canJump = false;
	}

	void FixedUpdate () {
		Turning ();
		float j = Input.GetAxisRaw ("Jump");
		//Debug.Log (j);
		//if (j=true){playerRigidbody.AddForce (0f, jumpforce,  0f);}
		//float j = Input.GetAxis (camT.transform.rotation.y);
		//float h = Input.GetAxisRaw ("Horizontal");
		//float h = Input.GetAxisRaw ("Horizontal");
		//float v = Input.GetAxisRaw ("Vertical");
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		//playerRigidbody.AddRelativeForce (0f, 0f, v * speed);
		playerRigidbody.AddForce (0f, 0f, v * speed);
		playerRigidbody.AddForce (h * speed, 0f, 0f);
		if (canJump == true) {
			playerRigidbody.AddForce (0f, j * jumpforce, 0f);

		}
		//////////////////////////////////////////////////////////////////Debug.Log (canJump);

		//playerRigidbody.AddRelativeTorque (0f, h * turnSpeed, 0f);


		//Move (h, v);
		//Jumping (h, v, j);
		//Turning ();

		//playerQ = Quaternion.LookRotation(camV) ;
		//playerRigidbody.transform.rotation = Quaternion.LookRotation(camV, camV);
		//вращение относительно камеры по Y
		//float camY = cam.transform.eulerAngles.y;
		//playerRigidbody.transform.eulerAngles = new Vector3 (0, camY, 0);


	}

	void Jumping(){
		
	}
	/*void Move(float h, float v){

		//movement = transform.InverseTransformDirection(cam);

		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
		playerRigidbody.MovePosition (transform.position + movement);

		//camV = Vector3.Scale(camT.forward, new Vector3(1, 0, 1)).normalized;

		//movement = v*camV + h*camV;

		//m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
		//m_Move = v*m_CamForward + h*m_Cam.right;


		//playerQ = Quaternion.LookRotation(camV) ;

		//playerRigidbody.MoveRotation (cam.transform.rotation);        
		//playerRigidbody.MoveRotation (transform.Rotate(0f, 45f, 0f));
	}*/



	void Turning(){
		/*Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit floorHit;
		if (Physics.Raycast (camRay, out floorHit, camRayLength, floorMask)) {*/
			Vector3 playerToMouse = ResButton.mousePos - transform.position;
			playerToMouse.y = 0f;
			Quaternion newRotation = Quaternion.LookRotation (playerToMouse);
			playerRigidbody.MoveRotation (newRotation);
		
	}

	
		
}
