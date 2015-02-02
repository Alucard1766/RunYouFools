using UnityEngine;
using System.Collections;

public class WalkingBehaviour : MonoBehaviour {
	
	public float Speed;
	public int playerNr;

	private SpriteRenderer _spriteRenderer;
	
	// Use this for initialization
	void Start () {
		_spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		var horizontalSpeed = Input.GetAxis("Horizontal");
		var verticalSpeed = Input.GetAxis("Vertical");

		
		
		rigidbody2D.velocity = new Vector2(Mathf.Lerp(0, horizontalSpeed * Speed, 0.8f),
		                                   Mathf.Lerp(0, verticalSpeed * Speed, 0.8f));

		if(Mathf.Abs(rigidbody2D.velocity.x) > Mathf.Abs(rigidbody2D.velocity.y))
		{
		if(rigidbody2D.velocity.x > 0)
			rigidbody2D.MoveRotation(0);
		if(rigidbody2D.velocity.x < 0)
			rigidbody2D.MoveRotation(180);
		}
		else 
		{
		if(rigidbody2D.velocity.y > 0)
			rigidbody2D.MoveRotation(90);
		if(rigidbody2D.velocity.y < 0)
			rigidbody2D.MoveRotation(270);
		}

		//transform.Rotate(Vector3.forward, 90); 
	}
}