using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResClick : MonoBehaviour {


	Rigidbody resRB;
	GameObject player;
	Transform playerT;
	public Transform originT;
	public LineRenderer pullLine;
	private Transform targetT;


	void Awake () {
		player = GameObject.FindWithTag ("Player");
		playerT = player.transform;
		resRB = GetComponent<Rigidbody>();

		}

	void OnMouseOver(){
		
		bool pull = Input.GetMouseButton (0);
		if ((pull == true)&&(ResButton.buildModeOn == false))  {
			resRB.AddForce((playerT.position - resRB.transform.position)*0.1f) ;
			pullLine.SetPosition (0, originT.position);
			pullLine.SetPosition (1, resRB.transform.position);
		}  
		if (pull == false) {
			pullLine.SetPosition (1, originT.position);

		}

	}

	void FixedUpdate(){
		
	
	}


	void Update () {

	}
}
