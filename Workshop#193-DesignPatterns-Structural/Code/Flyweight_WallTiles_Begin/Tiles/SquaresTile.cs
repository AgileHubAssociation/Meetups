namespace Flyweight_WallTiles_Begin.Tiles
{
    public class SquaresTile : Tile
    {
        public SquaresTile(int x, int y, int width, int height)
        {
            ImageUrl = @"Images/pattern-squares.jpg";
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }
    }
}
