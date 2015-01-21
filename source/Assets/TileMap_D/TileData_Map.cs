
public class TileData_Map {

	public const int PLAIN = 0;
	public const int WALL = 10;



	int height;
	int width;

	int[,] map_data;

	int[,] map1 = new int[11,20]
		{{10,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10},
		{10,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10},
		{10,10,10,10,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10},
		{10,10,10,10,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10},
		{10,10,10,10,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10,10},
		{10,10,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10},
		{10,10,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10},
		{10,10,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10},
		{10,10,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10},
		{10,10,10,0,0,0,0,0,0,0,0,0,0,0,0,0,0,10,10,10},
		{10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10}}; 


	public TileData_Map(int height, int width, int mapNr){
		this.height = height;
		this.width = width;

		map_data = new int[height, width];

		string mapName = "map" + mapNr.ToString();
		WriteMapData (mapName);


	}

	void WriteMapData (string mapName)
	{
		map_data = map1;//TODO: Map mapName (Via List??)
	}

	public int GetTileAtCoord(int x, int y){ //TODO: Discuss Errorhandling
		return map_data[y,x];
	}
}
