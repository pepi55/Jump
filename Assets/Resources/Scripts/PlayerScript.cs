using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	
	public float speed;
	private SpriteAnimate sprAnim;
	
	// Use this for initialization
	void Start () {
		sprAnim = GetComponent<SpriteAnimate>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalMovement = Input.GetAxis("Horizontal");
		float verticalMovement = Input.GetAxis("Jump");
		Vector2 move = new Vector2(horizontalMovement, 0f);
		
		transform.Translate(move * speed * Time.deltaTime, Space.World);
		
		if (horizontalMovement != 0)
			sprAnim.animate(5, 2, 5, 24, 2, 0);
	}
}
