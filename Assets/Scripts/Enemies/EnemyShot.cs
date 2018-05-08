using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour {

	public Transform shotT;
		Vector3 shotPoint;
	public Rigidbody shot;
	//public Rigidbody heart;
	Rigidbody heart;
	//Rigidbody heartRB;
	float currDist;

	// Use this for initialization
	void Awake () {
		InvokeRepeating ("Shot", 0.1f, Random.Range(4f, 6f));
		heart = GameObject.FindGameObjectWithTag("Heart").GetComponent<Rigidbody> ();
	}

	void Shot()
	{
		if (currDist < 12f) {
			shotPoint = shotT.position;
			Rigidbody RB;
			RB = Instantiate (shot, shotPoint, Quaternion.identity) as Rigidbody;
			RB.AddForce ((heart.transform.position - RB.transform.position)*10);
			Destroy (RB.gameObject, 1f);
		}
		else
			return;
	}

	void FixedUpdate()
	{
		
		currDist = Vector3.Distance(heart.transform.position, transform.position);	

			
				
	}

	// Update is called once per frame
	void Update () {
		
	}
}
