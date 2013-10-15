using UnityEngine;
using System.Collections;

public class PickUpCounter : MonoBehaviour {
	private int maxCollectables;
	private int count;
	public GUIText countText;
	//public GUIText WonText;
	void Start()
	{
		GameObject[] collectables = GameObject.FindGameObjectsWithTag(Tags.collectable);
		maxCollectables = collectables.Length;
		count = 0;
		setCountTekst();
		//setWinText();
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == Tags.collectable)
		{
			other.gameObject.SetActive(false);
			count += 1;	
			setCountTekst();
			//setWinText();
		}
		if(other.tag == Tags.Einde)
		{
			if(count == maxCollectables)
			{
				
				Application.LoadLevel("Scene2");
				countText.text = "0";
			}
		}
		if(other.tag == Tags.Einde2)
		{
			if(count == maxCollectables)
			{
				
				Application.LoadLevel("Scene3");
				countText.text = "0";
			}
		}
	}
	void setCountTekst()
	{
		countText.text = "Count " + count+ "/" +maxCollectables;
	}
	/*void setWinText()
	{
		if(count == maxCollectables)
		{
			WonText.text = "Continue";
			countText.text = " ";
		}
		else{
			WonText.text = " ";	
		}
	}*/
	
}
