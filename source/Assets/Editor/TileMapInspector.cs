using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(TileMapGraphics))]
public class TileMapInspector : Editor {
	
	public override void OnInspectorGUI() {
		//base.OnInspectorGUI();
		DrawDefaultInspector();
		
		if(GUILayout.Button("Regenerate")) {
			TileMapGraphics tileMap = (TileMapGraphics)target;
			tileMap.BuildMesh();
			tileMap.AssignTextures();
		}
	}
}
