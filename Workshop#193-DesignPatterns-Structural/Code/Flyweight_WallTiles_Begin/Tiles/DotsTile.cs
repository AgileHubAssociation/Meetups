namespace Flyweight_WallTiles_Begin.Tiles
{
    public class DotsTile : Tile
    {
        public DotsTile(int x, int y, int width, int height)
        {
            ImageUrl = @"Images/pattern-dots.jpg";
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }
    }
}
