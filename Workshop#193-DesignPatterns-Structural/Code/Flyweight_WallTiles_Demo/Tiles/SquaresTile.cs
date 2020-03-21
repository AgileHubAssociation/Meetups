namespace Flyweight_WallTiles_Demo.Tiles
{
    public class SquaresTile : Tile
    {
        public SquaresTile(int width, int height)
        {
            ImageUrl = @"Images/pattern-squares.jpg";
            Width = width;
            Height = height;
        }
    }
}
