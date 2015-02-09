using UnityEngine;
using System.Collections;

public class PowerUpBehaviourLightning : PowerUpBehaviour {
	
	
	// Use this for initialization
	protected override void Start () {
		powerUpType = "Sword";
		base.Start ();
	}


	protected override void Update(){
		Object.Destroy (gameObject);
	}
	
	
	public override void FirePowerUp(GameObject affectedPlayer){
		//TODO: Implement
	}
}