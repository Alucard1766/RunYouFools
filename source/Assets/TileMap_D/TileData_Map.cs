
public class TileData_Map {

	public const int PLAIN = 0;
	public const int WALL = 10;



	int height;
	int width;

	int[,] map_data;

	int[,] map1 = new int[11,20]
		{{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
		{0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1},
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
		this.height = height;
		this.width = width;

		map_data = new int[height, width];
		
		WriteMapData (map1);


	}

	void WriteMapData (int[,] mapName)
	{
		map_data = mapName;
	}

	public int GetTileAtCoord(int x, int y){ //TODO: Discuss Errorhandling
		return map_data[y,x];
	}
}
