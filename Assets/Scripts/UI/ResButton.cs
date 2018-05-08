using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class ResButton : MonoBehaviour {
	
	GameObject ghostBrickClone;
	public GameObject ghostBrick;
	public GameObject brickPrefab;
	public static Vector3Int mousePos;
	Vector3 buildPos;
	RaycastHit hit;
	public static bool buildModeOn = false;
	Vector3 lowerBuildPoint;


	void Awake () {
		
	}

	public void GRBC(){
		if (HitBox.GreenResCount > 0) {
			buildModeOn = true;
			//if (buildPos.y > 0)
			ghostBrickClone = Instantiate (ghostBrick, mousePos, Quaternion.identity);
		} 
			}

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast(ray, out hit, 200f)){//distance?
			mousePos = Vector3Int.CeilToInt(hit.point);
		}

		buildPos = mousePos + new Vector3 (0f, 0.5f, 0f);
		if (buildModeOn == true)
		ghostBrickClone.transform.position = buildPos;

		if ((Input.GetButtonDown("Fire1"))&&(buildModeOn == true)&&(buildPos.y > 0)){
			Destroy (ghostBrickClone);
			Instantiate (brickPrefab, buildPos, Quaternion.identity); 
			HitBox.GreenResCount -= 1;
			buildModeOn = false;
		}

	}
}


