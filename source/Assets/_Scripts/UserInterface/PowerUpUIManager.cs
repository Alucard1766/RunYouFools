using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PowerUpUIManager : MonoBehaviour {


	public Sprite beerImage;
	public Sprite swordImage;
	public Sprite lightningImage;

	private Dictionary<string, Sprite> collectionPowerUpImagesByString;

	private Image player1UIPowerUpImage;
	private Image player2UIPowerUpImage;
	private GameObject player1Background;
	private GameObject player2Background;


	void Start () {
		collectionPowerUpImagesByString = new Dictionary<string, Sprite>();
		collectionPowerUpImagesByString.Add ("Sword", swordImage);
		collectionPowerUpImagesByString.Add ("Beer", beerImage);
		collectionPowerUpImagesByString.Add ("Lightning", lightningImage);

		player1Background = transform.FindChild("Player1Background").gameObject;
		player2Background = transform.FindChild("Player2Background").gameObject;

		player1UIPowerUpImage = player1Background.transform.FindChild ("PowerUpImageP1").gameObject.GetComponent<Image>();
		player2UIPowerUpImage = player2Background.transform.FindChild ("PowerUpImageP2").gameObject.GetComponent<Image>();
	}

	public void CollectedPowerUp(string powerUpType, int playerNr){
		if (playerNr == 1) {
			player1UIPowerUpImage.color = new Color(1,1,1,1);
			player1UIPowerUpImage.sprite = (Sprite)collectionPowerUpImagesByString[powerUpType];
		} else {
			player2UIPowerUpImage.color = new Color(1,1,1,1);
			player2UIPowerUpImage.sprite = (Sprite)collectionPowerUpImagesByString[powerUpType];
		}
	}

	public void RemovePowerUp(int playerNr) {
		if (playerNr == 1) {
			player1UIPowerUpImage.color = new Color(1,1,1,0);
			player1UIPowerUpImage.sprite = new Sprite();
		} else {
			player2UIPowerUpImage.color = new Color(1,1,1,0);
			player2UIPowerUpImage.sprite = new Sprite();
		}
	}
}
