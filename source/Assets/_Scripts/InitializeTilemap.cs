using UnityEngine;
using System.Collections;
using X_UniTMX;
using System.Linq;

public class InitializeTilemap : MonoBehaviour {


	public string triggerObjectLayerName = "Trigger";
	// Use this for initialization
	void Start () {
		var map = this.GetComponent<TiledMapComponent>();

		//Find ObjectLayer Trigger
		MapObjectLayer triggerObjectLayer = map.TiledMap.GetObjectLayer (triggerObjectLayerName);


		//Initialize all trigger with their attributes
		foreach (MapObject triggerObject in triggerObjectLayer.Objects) {

			switch (triggerObject.Properties["TriggerType"].RawValue) {
			case "Finish":
				Debug.Log ("Creating finish line now");
				GameObject.Find(triggerObject.Name).AddComponent("FinishBehaviour");
				Debug.Log ("Done creating finish line");
				break;

			case "Start":
				GameObject.Find(triggerObject.Name).AddComponent("StartBehaviour");
				break;

			case "PowerUp":
				var powerUpObject = GameObject.Find(triggerObject.Name);
				powerUpObject.AddComponent("PowerUpBehaviour");
				powerUpObject.GetComponent<PowerUpBehaviour>().powerUpType = triggerObject.Properties["PowerupType"].RawValue;

				break;

			default:
				break;

			}
		}

		

	} 
}
