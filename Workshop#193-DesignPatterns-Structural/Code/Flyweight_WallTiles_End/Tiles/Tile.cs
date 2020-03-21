using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Flyweight_WallTiles_End.Tiles
{
    public class Tile
    {
        public static int InstancesCount;

        public string ImageUrl { get; protected set; }

        public Tile()
        {
            InstancesCount++;
        }

        public void AddTileOnWall(Canvas wall, int x, int y, int width, int height)
        {
            Image image = new Image()
            {
                Source = new BitmapImage(new Uri(this.ImageUrl, UriKind.RelativeOrAbsolute)),
                Width = width,
                Height = height
            };
            Canvas.SetLeft(image, x);
            Canvas.SetTop(image, y);
            wall.Children.Add(image);
        }
    }
}
