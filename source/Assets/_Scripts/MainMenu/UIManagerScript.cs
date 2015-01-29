using UnityEngine;
using System.Collections;

public class UIManagerScript: MonoBehaviour {
	
	public void StartGame(){
		Application.LoadLevel ("scene1");
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
