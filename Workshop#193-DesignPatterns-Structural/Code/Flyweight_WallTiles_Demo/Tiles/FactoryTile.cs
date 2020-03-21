using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_WallTiles_Demo.Tiles
{
    public enum TileType
    {
        Dots,
        Marble,
        Squares
    }
    public class FactoryTile
    {
        private Dictionary<TileType, Tile> _tilePool = new Dictionary<TileType, Tile>();

        public Tile GetTile(TileType type, int width, int height)
        {
            if (_tilePool.ContainsKey(type))
            {
                return _tilePool[type];
            }

            switch (type)
            {
                case TileType.Dots:
                    var dots = new DotsTile(width, height);
                    _tilePool.Add(type, dots);
                    return dots;
                case TileType.Marble:
                    var marble = new MarbleTile(width, height);
                    _tilePool.Add(type, marble);
                    return marble;
                case TileType.Squares:
                    var squares = new SquaresTile(width, height);
                    _tilePool.Add(type, squares);
                    return squares;
                default:
                    return null;
            }
        }
    }
}
