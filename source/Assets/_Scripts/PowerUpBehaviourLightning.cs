using UnityEngine;
using System.Collections;

public class PowerUpBehaviourLightning : PowerUpBehaviour {
	
	float goalTime;
	GameObject player;


	// Use this for initialization
	protected override void Start () {
		powerUpType = "Lightning";
		base.Start ();
	}


	protected override void Update(){
		//TODO: Implement Impact to other Player
		if (isActivated) {
			isActivated = false;
			Debug.Log("Activated");
		}
		if (isActive && Time.time > goalTime) {
			isDeactivated = true;
			isActive = false;
		}
		if (isDeactivated) {
			isDeactivated = false;
			Debug.Log("Deactivated");
			Object.Destroy(gameObject);
		}
	}
	
	
	public override void FirePowerUp(GameObject affectedPlayer){
		player = affectedPlayer;
		goalTime = Time.time + activeTime;
		isActivated = true;
		isActive = true;

		base.FirePowerUp (player);
	}
}