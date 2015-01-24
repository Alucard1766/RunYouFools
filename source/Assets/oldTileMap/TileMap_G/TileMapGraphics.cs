using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]
public class TileMapGraphics : MonoBehaviour {

	public int size_x = 20;
	public int size_y = 11;
	public float tileSize = 1.0f;
	public int layerLevel = 0;

	public Texture2D tileSet;
	public int tileResolutionInPx;

	public TextAsset mapTextData;

	int[,] mapData;
	TileData_Map tileMap;
	
	public void Start() {
		mapData = new int[size_y,size_x];
		ReadTextAssets ();

		BuildMesh();

		AssignTextures ();
	}

	void ReadTextAssets ()
	{
		string[] chars = mapTextData.text.Split (',');
		for (int y = 0; y < size_y; y++) {
			for (int x = 0; x < size_x; x++) {
				mapData[y,x] = int.Parse(chars[y * size_x + x]);
				Debug.Log(y + ", " + x + ", " + chars[y * size_x + x]);
			}
		}
	}

	Color[][] ChopTiles() {
		int numTilesPerRow = tileSet.width / tileResolutionInPx;
		int numRows = tileSet.height / tileResolutionInPx;

		Color[][] tiles = new Color[numTilesPerRow * numRows][];

		for (int y = 0; y < numRows; y++) {
			for (int x = 0; x < numTilesPerRow; x++) {
				tiles[y*numTilesPerRow + x] = tileSet.GetPixels(x * tileResolutionInPx, y * tileResolutionInPx, tileResolutionInPx, tileResolutionInPx);
			}
		}
		return tiles;
	}


	public void AssignTextures(){

		tileMap = new TileData_Map (mapData);

		int texWidth = size_x * tileResolutionInPx;
		int texHeight = size_y * tileResolutionInPx;

		Texture2D texture = new Texture2D (texWidth, texHeight);

		Color[][] tiles = ChopTiles ();

		for (int x = 0; x < size_x; x++) {
			for (int y = 0; y < size_y; y++) {
				Color[] p = tiles[tileMap.GetTileAtCoord(x,y)];
				//texture.SetPixels(x * tileResolutionInPx, y * tileResolutionInPx, tileResolutionInPx, tileResolutionInPx, p);
				texture.SetPixels(x * tileResolutionInPx,((size_y - 1) * tileResolutionInPx) - (y * tileResolutionInPx), tileResolutionInPx, tileResolutionInPx, p); //Spiegelung an X-Achse
			}
		}

		texture.filterMode = FilterMode.Point;
		texture.wrapMode = TextureWrapMode.Clamp;
		texture.Apply ();

		MeshRenderer mesh_renderer = GetComponent<MeshRenderer> ();
		mesh_renderer.sharedMaterials[0].mainTexture = texture;

		Debug.Log ("DoneTexture");
	}


	public void BuildMesh() {

		int numTiles 		= size_x * size_y;
		int numTriangles 	= numTiles * 2;
		int vertSize_x 		= size_x + 1;
		int vertSize_y 		= size_y + 1;
		int numVertices		= vertSize_x * vertSize_y;


		//Generate MeshData
		Vector3[] vertices = new Vector3[numVertices];
		Vector3[] normals  = new Vector3[numVertices];
		Vector2[] uv 	   = new Vector2[numVertices];

		int[] triangles = new int[numTriangles * 3];

		int x, y;
		for (y = 0; y < vertSize_y; y++) {
			for (x = 0; x < vertSize_x; x++) {
				vertices[y * vertSize_x + x] = new Vector3(x * tileSize, -y * tileSize, 1-layerLevel); //Tiles in den Hintergrund
				normals[y * vertSize_x + x]  = new Vector3(0, 0, -1);
				uv[y * vertSize_x + x]		 = new Vector2((float)x / size_x, 1f - (float)y / size_y);
			}
		}
		Debug.Log ("DoneVerts");

		for (y = 0; y < size_y; y++) {
			for (x = 0; x < size_x; x++) {
				int squareIndex = y * size_x + x;
				int triangleOffset = squareIndex * 6;
				triangles[triangleOffset + 0] = y * vertSize_x + x + 0;
				triangles[triangleOffset + 2] = y * vertSize_x + x + vertSize_x + 0;
				triangles[triangleOffset + 1] = y * vertSize_x + x + vertSize_x + 1;

				triangles[triangleOffset + 3] = y * vertSize_x + x + 0;
				triangles[triangleOffset + 5] = y * vertSize_x + x + vertSize_x + 1;
				triangles[triangleOffset + 4] = y * vertSize_x + x + 1;
			}
		}

		Debug.Log ("DoneTriangles");

		//Populate new Mesh with MeshData
		Mesh mesh = new Mesh ();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.normals = normals;
		mesh.uv = uv;


		//Assign Filter/Collider to mesh
		MeshFilter mesh_filter = GetComponent<MeshFilter>();
		MeshCollider mesh_collider = GetComponent<MeshCollider>();

		mesh_filter.mesh = mesh;
		mesh_collider.sharedMesh = mesh;

		Debug.Log ("DoneMesh");
	}
}
