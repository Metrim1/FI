using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

	static float spawnTimer = 0;
	public GameObject enemy1Pref;
	public Transform heart;
	static int spawnTimeRandom;
	public static int enemyConuter = 0;
	public UnityEngine.UI.Text EnemyCounterText;


	void Start () {
		spawnTimeRandom = Random.Range(5, 10); 

	}

	void EnemySpawner()
	{
		Instantiate (enemy1Pref, transform.position, Quaternion.identity);
		enemyConuter += 1;

	}

	void Update () {
		//ResCounterText.text = resConuter.ToString ();
		spawnTimeRandom = Random.Range(5, 10);
		spawnTimer += Time.deltaTime;
		if (((int)spawnTimer == spawnTimeRandom) && (enemyConuter < 1000)) {
			EnemySpawner ();
			spawnTimer = 0;
		}
		if (spawnTimer > 10)
			spawnTimer = 0;

		//Debug.Log (spawnTimer);
	}
}
