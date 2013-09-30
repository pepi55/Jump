using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		rigidbody.AddRelativeForce(Vector3.left * Time.deltaTime);
=======
	transform.Translate(Vector3.up * Time.deltaTime, Space.Self);
>>>>>>> origin/Fabian
	}
}
