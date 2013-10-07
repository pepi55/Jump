using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public float speed = 10;
	private SpriteAnimate sprAnim;
	
	// Use this for initialization
	void Start () {
		sprAnim = GetComponent<SpriteAnimate>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetAxis("Horizontal") == 1)
		{
			float horizontalMovement = Input.GetAxis("Horizontal");
			float verticalMovement = Input.GetAxis("Jump");
			Vector2 move = new Vector2(horizontalMovement, 0f);
			
			transform.Translate(move * speed * Time.deltaTime);
			
			if (horizontalMovement != 0)
				sprAnim.animate(5, 2, 5, 24, 2, 0);
		}
	}
}
