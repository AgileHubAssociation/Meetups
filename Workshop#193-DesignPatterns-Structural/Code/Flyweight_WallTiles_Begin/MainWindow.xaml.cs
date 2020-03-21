using System.Windows;
using Flyweight_WallTiles_Begin.Tiles;

namespace Flyweight_WallTiles_Begin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            FillWallWithTiles();
        }

        private void FillWallWithTiles()
        {
            var tileWidth = 60;
            var tileHeight = 60;

            var thirdWidth = (int)(wall.ActualWidth / 3);
            for (int x = 0; x < thirdWidth; x = x + tileWidth)
            {
                for (int y = 0; y < wall.ActualHeight; y = y + tileHeight)
                {
                    var tile = new MarbleTile(x, y, tileWidth, tileHeight);
                    tile.AddTileOnWall(wall);
                };
            }

            for (int x = thirdWidth; x < 2 * thirdWidth; x = x + tileWidth)
            {
                for (int y = 0; y < wall.ActualHeight; y = y + tileHeight)
                {
                    var tile = new SquaresTile(x, y, tileWidth, tileHeight);
                    tile.AddTileOnWall(wall);
                };
            }

            for (int x = 2 * thirdWidth; x < wall.ActualWidth; x = x + tileWidth)
            {
                for (int y = 0; y < wall.ActualHeight; y = y + tileHeight)
                {
                    var tile = new DotsTile(x, y, tileWidth, tileHeight);
                    tile.AddTileOnWall(wall);
                };
            }

            textBlockNumberOfTiles.Text = $"{Tile.InstancesCount} tiles were created";
        }
    }
}
