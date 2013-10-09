using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;
	
	void Start()
	{
		offset = new Vector3(0,30,0);	
	}
	void LateUpdate()
	{
		transform.position = player.transform.position + offset;
	}
}