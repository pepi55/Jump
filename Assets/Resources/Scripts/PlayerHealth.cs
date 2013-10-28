using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public int Health = 100;
	public GUIText HealthGUI;
	public AudioClip hitobject;
	// Use this for initialization
	void Start () {
	HealthGUI.text = "100";
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnCollisionEnter (Collision col) {
		if (col.collider.tag == Tags.obstacle)
		{
			Health -= 3;
			audio.PlayOneShot(hitobject, 0.9f);
			HealthGUI.text = Health.ToString();
			
		}
		if(Health <= 0)
		{
			Destroy(gameObject);
			Application.LoadLevel("Lose");
		}
	}
}