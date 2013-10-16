using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Vector3 posXrht = transform.position;
		
		posXrht.x = Random.Range(-90, 90);
		posXrht.z = -2;
		transform.position = posXrht;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -1500)
		{
			Application.LoadLevel("Win");
		}
	}
	
	/*void OnCollisionEnter (Collision col) {
		if (col.collider.tag == Tags.finish)
		{
			Application.LoadLevel("Win"); 
		}
	}*/
}
