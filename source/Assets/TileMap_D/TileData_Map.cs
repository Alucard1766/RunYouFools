using System.Collections.Generic;


public class TileData_Map {

	/*
	 * 0 = Floor
	 * 1 = Wall
	*/

	int height;
	int width;

	int[,] currentMapDataLayer0;

	int[,] map0Layer0 = new int[11,20]
		{{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
		{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
		{0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1},
		{0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1},
		{0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1},
		{0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1},
		{0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1},
		{0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1},
		{0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1},
		{0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1},
		{0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}};


	public TileData_Map(int height, int width){
		//this.height = height;
		//this.width = width;

		currentMapDataLayer0 = new int[height, width];
		currentMapDataLayer0 = map0Layer0;

	}


	public int GetTileAtCoord(int x, int y){ //TODO: Discuss Errorhandling
		return currentMapDataLayer0[y,x];
	}
}
