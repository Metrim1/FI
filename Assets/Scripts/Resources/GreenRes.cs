using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenRes : MonoBehaviour {
	
	Text GreenResText;

	void Awake () {
		GreenResText = GetComponent<Text> ();
	}

	void Update () {
		GreenResText.text = HitBox.GreenResCount.ToString();
	}
}
