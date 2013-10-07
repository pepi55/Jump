using UnityEngine;
using System.Collections;

public class SpriteAnimate : MonoBehaviour {
	
	public int cols;
	public int rows;
	public int cells;
	public int fps;
	
	public int row;
	public int col;
	
	string mainTex = "_MainTex";
	
	// Use this for initialization
	void Start () {
		renderer.material.SetTextureOffset(mainTex, new Vector2(row, col));
	}
	
	// Update is called once per frame
	void Update () {
		int index = (int) (fps * Time.time);
		index = index % cells;
		
		float uIndex = index % cols;
		float vIndex = index / cols;
		
		float sizeX = 1f / cols;
		float sizeY = 1f / rows;
		Vector2 size = new Vector2(sizeX, sizeY);
		
		float offsetX = 1f / cols * uIndex;
		float offsetY = 1f / rows * vIndex;
		Vector2 offset = new Vector2(offsetX, offsetY);
		
		renderer.material.SetTextureScale(mainTex, size);
		renderer.material.SetTextureOffset(mainTex, offset);
	}
}
