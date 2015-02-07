using UnityEngine;
using System.Collections;

public abstract class PowerUpBehaviour : MonoBehaviour {

	protected string powerUpType = "NotBeer";

	public float activeTime = 3.0f;
	protected bool isActivated;
	protected bool isDeactivated;
	protected bool isActive;

	protected PowerUpUIManager powerUpManager;
	protected PowerUpPlayerScript powerUpPlayer;

	virtual protected void Start(){
		powerUpManager = GameObject.Find ("PowerUps").GetComponent<PowerUpUIManager> ();
		isActivated = false;
		isDeactivated = false;
		isActive = false;
	}

	/// <summary>
	/// Lifecycle of PowerUp after activation, Destroy object at the end!
	/// </summary>
	protected abstract void Update ();



	void OnTriggerEnter2D(Collider2D other) {
		powerUpPlayer = other.gameObject.GetComponent<PowerUpPlayerScript>();
		powerUpPlayer.CollectPowerUp (this);
		powerUpManager.CollectedPowerUp (powerUpType, other.gameObject.GetComponent<WalkingBehaviour>().playerNr);
		gameObject.GetComponent<SpriteRenderer> ().enabled = false;
		gameObject.GetComponent<BoxCollider2D> ().enabled = false;
	}


	public virtual void FirePowerUp(GameObject player) {

		powerUpManager.RemovePowerUp (player.GetComponent<WalkingBehaviour>().playerNr);
	}

}
