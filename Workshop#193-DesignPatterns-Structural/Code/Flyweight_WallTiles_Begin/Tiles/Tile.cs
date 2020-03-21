using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Flyweight_WallTiles_Begin.Tiles
{
    public class Tile
    {
        public static int InstancesCount;

        public string ImageUrl { get; protected set; }

        public int X { get; protected set; }
        public int Y { get; protected set; }

        public int Height { get; protected set; }
        public int Width { get; protected set; }

        public Tile()
        {
            InstancesCount++;
        }

        public void AddTileOnWall(Canvas wall)
        {
            Image image = new Image()
            {
                Source = new BitmapImage(new Uri(this.ImageUrl, UriKind.RelativeOrAbsolute)),
                Width = this.Width,
                Height = this.Height
            };
            Canvas.SetLeft(image, this.X);
            Canvas.SetTop(image, this.Y);
            wall.Children.Add(image);
        }
    }
}
