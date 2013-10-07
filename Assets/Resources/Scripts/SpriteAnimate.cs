using UnityEngine;
using System.Collections;

public class SpriteAnimate : MonoBehaviour {
	


	
	// Update is called once per frame
	public void Animate ( int cols,  int rows,  int cells,	 int fps,	 int col,	 int row, string mainTex = "_MainTex")
	{
		int index = (int) (fps * Time.time);
		index = index % cells;
		
		float uIndex = index % cols;
		float vIndex = index / cols;
		
		float sizeX = 1f / cols;
		float sizeY = 1f / rows;
		Vector2 size = new Vector2(sizeX, sizeY);
		
		float offsetX = (uIndex + col) * size.x;
		float offsetY = (vIndex + row) * size.y;
		Vector2 offset = new Vector2(offsetX, offsetY);
		
		renderer.material.SetTextureScale(mainTex, size);
		renderer.material.SetTextureOffset(mainTex, offset);
	}
}
