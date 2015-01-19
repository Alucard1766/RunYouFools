using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]
public class TileMapGraphics : MonoBehaviour {

	public int size_x = 50;
	public int size_y = 30;
	public float tileSize = 1.0f;

	public Texture2D tileSet;
	public int tileResolutionInPx;


	void Start() {
		BuildMesh();
	}

	void AssignTextures(){

	}


	public void BuildMesh() {
		//Generate MeshData

		//Populate new Mesh with MeshData

		//Assign Filter/Collider to mesh

		//Call Method to Assign Vertecies to Texture
	}
}
