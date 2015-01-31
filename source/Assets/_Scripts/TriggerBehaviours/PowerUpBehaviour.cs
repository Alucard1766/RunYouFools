using UnityEngine;
using System.Collections;

public class PowerUpBehaviour : MonoBehaviour {

	public string powerUpType;


	void OnTriggerEnter2D(Collider2D other) {
		other.gameObject.GetComponent<PowerUpManager> ().CollectedPowerUp (powerUpType);
		Object.Destroy (gameObject);
	}
}
