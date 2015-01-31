using UnityEngine;
using System.Collections;

public class CamFollowsPlayer : MonoBehaviour {
	
	public Transform player1;
	public Transform player2;
	public float smooth = 5.0f;
	//public float divisorYAxisOffset = 2f;



	void Update () {

		Vector3 desiredCameraPosition = Vector3.Lerp(player1.position, player2.position, 0.5f); //Mitte zwischen P1 und P2

		this.camera.orthographicSize = Vector3.Distance (desiredCameraPosition, player1.position) / 1f;

		desiredCameraPosition.z = transform.position.z; //Lock Z-Axis



		//desiredCameraPosition.y += Camera.main.orthographicSize/divisorYAxisOffset;
		transform.position = Vector3.Lerp(transform.position, desiredCameraPosition, Time.deltaTime * smooth);

		                               
	}
}
