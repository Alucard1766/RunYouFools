using UnityEngine;
using System.Collections;

public class CamFollowsPlayer : MonoBehaviour {



	public Transform target;
	public float smooth = 5.0f;
	public float divisorYAxisOffset = 2f;

	//TODO: Implement Start() with starting point betweent both starts

	void Update () {
		Vector3 desiredCameraPosition = target.position;
		desiredCameraPosition.z = transform.position.z; //Lock Z-Axis
		desiredCameraPosition.y += Camera.main.orthographicSize/divisorYAxisOffset;
		transform.position = Vector3.Lerp(transform.position, desiredCameraPosition, Time.deltaTime * smooth);
		                               
	}
}
