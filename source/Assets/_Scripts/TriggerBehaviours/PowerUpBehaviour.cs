using UnityEngine;
using System.Collections;

public class PowerUpBehaviour : MonoBehaviour {

	public string powerUpType;

	private PowerUpUIManager powerUpManager;

	void Start(){
		powerUpManager = GameObject.Find ("PowerUps").GetComponent<PowerUpUIManager> ();
	}


	void OnTriggerEnter2D(Collider2D other) {
		powerUpManager.CollectedPowerUp (powerUpType, other.gameObject.GetComponent<WalkingBehaviour>().playerNr);
		Object.Destroy (gameObject);
	}
}
