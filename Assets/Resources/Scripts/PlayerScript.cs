using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed = 10;
	
	private SpriteAnimate sprAnim;
	// Use this for initialization
	void Start () {
		SpriteAnimate = GetComponent<SpriteAnimate>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
				
		
			float x = -Input.GetAxis("Horizontal");
			if(x !=0f)
			{
				sprAnim.Animate(5,2,0,0,5,2);	
			}
			Vector2 movement = new Vector2(x,0);
		
			transform.Translate(movement * speed * Time.deltaTime);
		}
	}
}
