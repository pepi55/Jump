using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {
	
	private int amount = 0;
	public GUIText score;
	
	// Use this for initialization
	void Start () {
	score.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter (Collider col) {
		if (col.collider.tag == Tags.collectable)
		{
			amount += 1;
			score.text = amount.ToString();
			
			Destroy(col.gameObject);
		}
	}
}
