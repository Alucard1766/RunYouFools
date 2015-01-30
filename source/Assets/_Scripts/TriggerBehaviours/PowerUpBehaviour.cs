using UnityEngine;
using System.Collections;

public class PowerUpBehaviour : MonoBehaviour {

	public string powerUpType;


	// Use this for initialization
	void Start () {
		Debug.Log ("Message from PowerUp: Script loaded with type: " + powerUpType + "!!");

	}

	void OnTriggerEnter2D(Collider2D other) {
		other.gameObject.GetComponent<PowerUpManager> ().CollectedPowerUp (powerUpType);
	}
}
