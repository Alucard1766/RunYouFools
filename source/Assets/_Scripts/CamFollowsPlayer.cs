using UnityEngine;
using System.Collections;

public class CamFollowsPlayer : MonoBehaviour {
	
	public Transform player1;
	public Transform player2;

	public float distance;

	void Update () {

		Vector3 desiredCameraPosition = Vector3.Lerp(player1.position, player2.position, 0.5f); //Mitte zwischen P1 und P2

		this.camera.orthographicSize = Vector3.Distance (desiredCameraPosition, player1.position) * distance;

		desiredCameraPosition.z = transform.position.z; //Lock Z-Axis

		transform.position = new Vector3(desiredCameraPosition.x, desiredCameraPosition.y, transform.position.z);
	}
}
