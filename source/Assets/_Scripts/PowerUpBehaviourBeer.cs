using UnityEngine;
using System.Collections;

public class PowerUpBehaviourBeer : PowerUpBehaviour {
 	


	float goalTime;
	GameObject player;


	// Use this for initialization
	protected override void Start () {
		powerUpType = "Beer";
		base.Start ();
	}

	protected override void Update(){
		if (isActivated) {
			player.GetComponent<WalkingBehaviour> ().Speed *= 2;
			isActivated = false;
			Debug.Log("Activated");
		}
		if (isActive && Time.time > goalTime) {
			isDeactivated = true;
			isActive = false;
		}
		if (isDeactivated) {
			isDeactivated = false;
			player.GetComponent<WalkingBehaviour> ().Speed /= 2;
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
