using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		
		
		float horizontalMovement = Input.GetAxis("Horizontal");
		float verticalMovement = Input.GetAxis("Jump");
		Vector3 movement = new Vector3(horizontalMovement, verticalMovement, 0.0f);
		rigidbody.AddForce(movement * speed * Time.deltaTime);	
			
			
			
			
			
		
	}
}
