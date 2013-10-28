using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	private Vector3 plus = new Vector3 (0,60,0);
	
	// Use this for initialization
	void Start () {
		offset = transform.position + plus;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
