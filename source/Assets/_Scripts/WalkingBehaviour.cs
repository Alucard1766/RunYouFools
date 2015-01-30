using UnityEngine;
using System.Collections;

public class WalkingBehaviour : MonoBehaviour {
	
	public float Speed;


	private SpriteRenderer _spriteRenderer;
	
	// Use this for initialization
	void Start () {
		_spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		var horizontalSpeed = Input.GetAxis("Horizontal");
		var verticalSpeed = Input.GetAxis("Vertical");
		
		
		rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * Speed, 0.8f),
		                                   Mathf.Lerp(0, Input.GetAxis("Vertical") * Speed, 0.8f));

	}
}