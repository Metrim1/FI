using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	Rigidbody enemyRB;
	public float enemySpeed = 0.1f;
	public float rangeOfFire = 10;
	//public Rigidbody heart;
	Rigidbody heart;
	public float currDist;
	float moveForceX;
	float moveForceY;
	float moveForceZ;
	//Rigidbody heartRB;





	void addMove(){

		enemyRB.AddRelativeForce (moveForceX, moveForceY, moveForceZ);
	}

	// Use this for initialization
	void Start () {
		heart = GameObject.FindGameObjectWithTag("Heart").GetComponent<Rigidbody> ();
		InvokeRepeating ("addMove", 0.1f, Random.Range (1f, 5f));
		enemyRB = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		
	currDist = Vector3.Distance(heart.transform.position, transform.position);

		enemyRB.transform.LookAt (heart.transform);
		if (currDist > rangeOfFire)
			enemyRB.AddForce ((heart.transform.position - transform.position) * enemySpeed);
	}




	void Update () {
		moveForceX = Random.Range(50f, -50f);
		moveForceY = Random.Range(1f, -1f);
		moveForceZ = Random.Range(1f, -1f);
		
	}
}
