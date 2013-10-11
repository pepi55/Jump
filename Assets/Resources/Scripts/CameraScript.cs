using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject target;
	private Vector3 offset;
	
	void Start()
	{
		offset = new Vector3(0,30,0);	
	}
	void FixedUpdate()
	{
		transform.position = target.transform.position + (offset * 0.5f);
	}
}
