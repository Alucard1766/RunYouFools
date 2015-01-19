
public class TileData_Map {
	TileData_Tile[] tiles;
	int height;
	int width;


	public TileData_Map(int height, int width){
		this.height = height;
		this.width = width;

		tiles = new TileData_Tile[ this.height * this.width ];
	}

	public TileData_Tile GetTileFromCoord(int x, int y) {

		if (x < 0 || y < 0 || x >= width || y >= height) {
			return null; //TODO: Errorhandling mit MAU besprechen
		}
		return tiles[ y * width + x];
	}
}
