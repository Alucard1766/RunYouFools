using UnityEngine;
using System.Collections;

public class PowerUpManager : MonoBehaviour {

	public UnityEngine.UI.Image UIPowerUpImage;
	public Sprite beerImage;
	public Sprite swordImage;


	private bool hasPowerup;
	private string currentPowerUp;
	private Hashtable collectionPowerUpImagesByString;


	void Start () {
		hasPowerup = false;
		collectionPowerUpImagesByString = new Hashtable ();
		collectionPowerUpImagesByString.Add ("Sword", swordImage);
		collectionPowerUpImagesByString.Add ("Beer", beerImage);
	}

	public void CollectedPowerUp(string powerUpType){
		if (!hasPowerup) //Collecting only possible when no power up is already equipped
		{
			currentPowerUp = powerUpType;
			hasPowerup = true;
			UIPowerUpImage.color = new Color(1,1,1,1);
			UIPowerUpImage.sprite = (Sprite)collectionPowerUpImagesByString[powerUpType];
		}
	}
}
