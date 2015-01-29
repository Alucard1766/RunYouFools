using UnityEngine;
using System.Collections;

public class FinishBehaviour : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Debug.Log ("Message from Finish Line: Script loaded!");
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log (other.gameObject.name + " reached the finish line");

	}
}
