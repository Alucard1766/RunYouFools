using UnityEngine;
using System.Collections;

public class RankingUIManager : MonoBehaviour {

	public Transform player1;
	public Transform player2;
	public UnityEngine.UI.Text position1;
	public UnityEngine.UI.Text position2;

	private Transform finishLine;

	// Use this for initialization
	void Start () {
		position1.text = "1. Player1";
		position2.text = "2. Player2";
	}
	
	// Update is called once per frame
	void Update () {
		if (player1.position.y - finishLine.position.y > player2.position.y - finishLine.position.y) {
			position1.text = "1. Player1";
			position2.text = "2. Player2";
		} else {
			position1.text = "1. Player2";
			position2.text = "2. Player1";
		}
	}

	public void SetFinishline(Transform t){
		finishLine = t;
	}
}
