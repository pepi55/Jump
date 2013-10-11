using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour {
	public float RotationSpeed = 400;	
	private Vector3 Right;
	private Vector3 Left;

	
	// Use this for initialization
	void Start () {
		Left = new Vector3(0,-RotationSpeed* 10 * Time.deltaTime,0);
		Right = new Vector3(0,RotationSpeed* 10 * Time.deltaTime,0);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal") >= 0.2f)
		{
			transform.Rotate(Right, Space.World);
			
		}
		if(Input.GetAxis("Horizontal") <= -0.2f)
		{
			transform.Rotate(Left, Space.World);
			
		}
		
		Debug.Log(Input.GetAxis("Horizontal"));
	}
}
