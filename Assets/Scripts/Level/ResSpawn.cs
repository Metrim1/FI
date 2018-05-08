using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResSpawn : MonoBehaviour {

	float spawnTimer = 0;
	public Rigidbody stonePref;
	int spawnTimeRandom;
	public static int resConuter = 0;
	public UnityEngine.UI.Text ResCounterText;
	public Transform heart;


	void Start () {
		spawnTimeRandom = Random.Range(5, 10); 
		
	}
	
	void ResSpawner()
	{
		Rigidbody RB;
		RB = Instantiate (stonePref, transform.position, Quaternion.identity) as Rigidbody;
		RB.AddForce (heart.position - RB.transform.position); 
		resConuter += 1;
	
	}

	void Update () {
		ResCounterText.text = resConuter.ToString ();
		spawnTimeRandom = Random.Range(5, 10);
		spawnTimer += Time.deltaTime;
		if (((int)spawnTimer == spawnTimeRandom) && (resConuter < 10)) {
			ResSpawner ();
			spawnTimer = 0;
		}
		if (spawnTimer > 10)
			spawnTimer = 0;
		
		Debug.Log (spawnTimer);
	}
}
