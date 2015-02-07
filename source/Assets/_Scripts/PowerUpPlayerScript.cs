using UnityEngine;
using System.Collections;

public class PowerUpPlayerScript : MonoBehaviour {

	bool hasPowerup;
	PowerUpBehaviour powerUpComponent;
	int playerNr;

	// Use this for initialization
	void Start () {
		hasPowerup = false;
		playerNr = this.gameObject.GetComponent<WalkingBehaviour> ().playerNr;
	}
	
	// Update is called once per frame
	void Update () {
		if (hasPowerup && Input.GetButtonDown("Fire1")) {
			powerUpComponent.FirePowerUp(this.gameObject);
			hasPowerup = false;
			powerUpComponent = null;
		}
	}

	public void CollectPowerUp (PowerUpBehaviour powerUp)
	{
		if (!hasPowerup) {
			powerUpComponent = powerUp;
			hasPowerup = true;
		}

	}
}
