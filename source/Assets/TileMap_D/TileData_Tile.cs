public enum TILETYPE {
	PLAIN,
	WALL
}

public class TileData_Tile {

	public bool isWalkable;
	public TILETYPE tiletype;

	public TileData_Tile(TILETYPE tiletype){

		this.tiletype = tiletype;

		if (tiletype == TILETYPE.PLAIN) {
			isWalkable = true;
		} else if (tiletype == TILETYPE.WALL) {
			isWalkable = false;
		}
	}
}
